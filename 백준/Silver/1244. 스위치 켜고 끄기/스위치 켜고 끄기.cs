using System.ComponentModel.DataAnnotations.Schema;

namespace CodeTest
{
    class Program
    {
        struct Student
        {
            public string sex;
            public int value;

            public void DataInput(string data)
            {
                string[] splitStr = data.Split(' ');

                string sexCode = splitStr[0];

                this.sex = sexCode == "1" ? "Male" : "Female";
                this.value = Convert.ToInt32(splitStr[1]);
            }
        };

        static void Main(string[] args)
        {
            int switchAmount = Convert.ToInt32(Console.ReadLine());
            string switchStatusStr = Console.ReadLine() ?? "";

            int studentLen = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[studentLen];

            int[] switchStatus = new int[switchAmount];

            switchStatus = switchStatusStr.Split(' ')
                                        .Select(s => Convert.ToInt32(s))
                                        .ToArray();

            for (int i = 0; i < studentLen; i++)
            {
                string inputDataStr = Console.ReadLine() ?? "";
                student[i].DataInput(inputDataStr);
            }

            for (int k = 0; k < studentLen; k++)
            {
                if (student[k].sex == "Male")
                {
                    ProcessMale(ref switchStatus, student[k].value);
                }
                else
                {
                    ProcessFemale(ref switchStatus, student[k].value);
                }
            }

            string result = "";
            for (int i = 0; i < switchStatus.Length; i += 20)
            {
                result += string.Join(" ", switchStatus.Skip(i).Take(20).Select(s => s.ToString()));
                result += "\n";
            }

            Console.WriteLine(result);
        }

        static void ProcessMale(ref int[] switchStatus, int value)
        {
            //남학생은 스위치 번호가 자기가 받은 수의 배수이면, 그 스위치의 상태를 바꾼다.
            for (int i = value; i <= switchStatus.Length; i += value)
            {
                switchStatus[i - 1] ^= 1;
            }
        }

        static void ProcessFemale(ref int[] switchStatus, int value)
        {
            //여학생은 자기가 받은 수와 같은 번호가 붙은 스위치를 중심으로 좌우가 대칭이면서
            //가장 많은 스위치를 포함하는 구간을 찾아서, 그 구간에 속한 스위치의 상태를 모두 바꾼다.
            value -= 1;
            switchStatus[value] ^= 1;

            int upperIndex = value + 1;
            int lowerIndex = value - 1;
            while (true)
            {
                if (upperIndex >= switchStatus.Length) break;
                if (lowerIndex < 0) break;
                if (switchStatus[upperIndex] == switchStatus[lowerIndex])
                {
                    switchStatus[upperIndex++] ^= 1;
                    switchStatus[lowerIndex--] ^= 1;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
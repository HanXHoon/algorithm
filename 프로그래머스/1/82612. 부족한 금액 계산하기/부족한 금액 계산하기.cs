using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long fianl_price = 0;

        for (int i = 1; i <= count; i++)
        {
            fianl_price += price * i;
        }

        if (money - fianl_price > 0) return 0;

        return fianl_price - money;
    }
}
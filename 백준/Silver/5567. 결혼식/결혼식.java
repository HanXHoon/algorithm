import java.io.*;
import java.util.*;

public class Main {
    static Map<Integer, List<Integer>> graph;
    static boolean[] visited;
    static int n, m;
    static int answer;

    public static void main(String args[]) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        n = Integer.parseInt(br.readLine());
        graph = new HashMap<>();
        visited = new boolean[n + 1];
        answer = 0;

        for (int i = 1; i <= n; i++) {
            graph.put(i, new ArrayList<>());
        }

        m = Integer.parseInt(br.readLine());
        StringTokenizer st;
        for (int i = 0; i < m; i++) {
            st = new StringTokenizer(br.readLine());
            int a = Integer.parseInt(st.nextToken());
            int b = Integer.parseInt(st.nextToken());
            graph.get(a).add(b);
            graph.get(b).add(a);
        }
        bfs();
        System.out.println(answer);
    }

    private static void bfs() {
        Queue<int[]> queue = new LinkedList<>();

        queue.add(new int[] { 1, 0 });
        visited[1] = true;

        while (!queue.isEmpty()) {
            int[] current = queue.poll();
            int curNum = current[0];
            int dist = current[1];
            if (dist < 2) {
                for (int i : graph.get(curNum)) {
                    if (!visited[i]) {
                        visited[i] = true;
                        queue.add(new int[] { i, dist + 1 });
                        answer++;
                    }
                }
            }
        }
    }
}
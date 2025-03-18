namespace LeetCodeSolutions.Problems {
    public class GasStation {
        public static int CanCompleteCircuit(int[] gas, int[] cost) {
            for(int i = 0; i < gas.Length; i++) {
                var currentGas = gas[i];
                var start = i;
                for(int j = i; j < i + gas.Length; j++) {
                    if(currentGas < cost[j % cost.Length]) {
                        break;
                    }

                    if(((j + 1) % cost.Length) == start) {
                        return i;
                    }

                    currentGas = currentGas - cost[j % cost.Length] + gas[(j + 1) % cost.Length];
                }
            }
            return -1;
        }
    }
}
﻿/*
1470. Shuffle the Array

Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

Return the array in the form [x1,y1,x2,y2,...,xn,yn].
*/
public static class ShuffleTheArray {
    public static int[] Shuffle(int[] nums, int n) {
        int[] shuffled = new int[2 * n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            shuffled[index++] = nums[i];
            shuffled[index++] = nums[i + n];
        }
        return shuffled;
    }

}

using System.Collections.Generic;

namespace SumFinderLibrary
{
    public class SumFinder
    {
        /// <summary>
        /// Находит минимальный по индексу диапазон элементов списка, сумма которых равна заданному значению.
        /// Используется алгоритм скользящего окна для эффективного поиска подмассива с суммой sum.
        /// Если такой диапазон не найден, возвращает start = 0 и end = 0.
        /// </summary>
        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0;
            end = 0;
            int left = 0;
            ulong currentSum = 0;

            for (int right = 0; right < list.Count; right++)
            {
                currentSum += list[right];
                while (currentSum > sum && left <= right)
                {
                    currentSum -= list[left];
                    left++;
                }
                if (currentSum == sum)
                {
                    start = left;
                    end = right + 1;
                    return;
                }
            }
            start = 0;
            end = 0;
        }
    }
}

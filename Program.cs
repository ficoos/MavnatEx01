using System;

namespace MavnatEx01 {
class MainClass {
	public static void Main(string[] args) {
		var array = new int[] { 989, 12312, 123, 2, 0213, -2 };
		Quicksort(array, 0, array.Length - 1);
		foreach (var i in array) {
			Console.Write(string.Format("{0}, ", i));
		}
	}

	public static void Quicksort<T>(T[] array, int startIndex, int endIndex) where T : IComparable {
		int p = Partition(array, startIndex, endIndex);

		if (p > startIndex) {
			Quicksort(array, startIndex, p - 1);
		}

		if (p < endIndex) {
			Quicksort(array, p + 1, endIndex);
		}
	}

	public static void Swap<T>(T[] array, int index1, int index2) {
		T tmp = array[index1];
		array[index1] = array[index2];
		array[index2] = tmp;
	}

	public static int Partition<T>(T[] array, int startIndex, int endIndex) where T : IComparable {
		int pivotIndex = startIndex;
		T pivotValue = array[pivotIndex];
		int storeIndex = startIndex;

		Swap(array, pivotIndex, endIndex);
		for (int i = startIndex; i < endIndex; i++) {
			if (array[i].CompareTo(pivotValue) <= 0) {
				Swap(array, i, storeIndex);
				storeIndex++;
			}
		}

		Swap(array, storeIndex, endIndex);

		return storeIndex;
	}
}
}

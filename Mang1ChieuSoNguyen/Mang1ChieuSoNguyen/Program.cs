using System;
using System.Collections.Generic;
using static System.Console;

namespace Mang1ChieuSoNguyen
{
	class Program
	{
		static int n;
		static int[] a = new int[100];
		//static int[] a = GeneratorRandom();


		static void Main(string[] args)
		{
			//Creat();
			a = GeneratorRandomz(ref n);
			OutputOfArray(a, n);
			//int lengthB = 0;
			//int[] b = GeneratorRandomz(ref lengthB);
			//OutputOfArray(b, lengthB);

			int x = 0;
			int y = 0;
			int length = 0;
			int amount = 0;

			//WriteLine("Enter the element to be deleted: ");
			//x = int.Parse(ReadLine());
			//DelFirstX(x);
			//OutputOfArray(a, n);

			//Write("Enter the element you want to find: ");
			//x = int.Parse(ReadLine());
			//WriteLine("The first position of the element {0} is {1}", x, FinalPosition(x));

			//WriteLine("\nArray of negative numbers...");
			//OutputOfArray(NegativeNumbers(ref length), length);

			//WriteLine("\nArray of positive numbers...");
			//OutputOfArray(PositiveNumbers(ref length), length);

			//WriteLine("\nArray of even numbers...");
			//OutputOfArray(EvenNumbers(ref length), length);

			//WriteLine("\nArray of odd numbers...");
			//OutputOfArray(OddNumbers(ref length), length);

			//WriteLine("\nThe most appear element is...");
			//OutputOfArray(TheMost(ref length), length);

			//WriteLine("\nElement appear at leats is...");
			//OutputOfArray(AtLeats(ref length), length);

			//Write("\nEnter number: ");
			//x = int.Parse(ReadLine());
			//WriteLine("\nArray of numbers greater than {0}...", x);
			//OutputOfArray(GreaterThanX(ref length, x), length);
			//WriteLine("\nArray of numbers less than {0}...", x);
			//OutputOfArray(LesserThanX(ref length, x), length);

			//Write("\nEnter a position: ");
			//do
			//{
			//	x = int.Parse(ReadLine());
			//} while (x > n - 1);
			//WriteLine("The elements in the array are from position {0}...", x);
			//OutputOfArray(ElementOfArray_Location(ref length, x, amount), length);

			//Write("\nEnter a value to add: ");
			//x = int.Parse(ReadLine());
			//Write("Enter a location to add: ");
			//int location = int.Parse(ReadLine());
			//ElementAdd_Location(x, location);
			//OutputOfArray(a, n);

			//Write("\nEnter a value to add to the top of the list: ");
			//x = int.Parse(ReadLine());
			//ElementAdd_Top(x);
			//OutputOfArray(a, n);

			//Write("\nEnter a value to add to the end of the list: ");
			//x = int.Parse(ReadLine());
			//ElementAdd_End(x);
			//OutputOfArray(a, n);

			//WriteLine("\nAdd array B at the beginning off array A");
			//AddAnArray_Top(b, lengthB);
			//OutputOfArray(a, n);

			//WriteLine("\nAdd array B to the end of array A");
			//AddAnArray_Last(b, lengthB);
			//OutputOfArray(a, n);

			//WriteLine("\nEnter a location to insert: ");
			//x = int.Parse(ReadLine());
			//WriteLine("\nInserts array B at position {0} in array A", x);
			//AddAnAraay_Location(b, lengthB, x);
			//OutputOfArray(a, n);

			//WriteLine("\nDelete array elements B that exist in array A");
			//DeleteArrayInArray(b, ref length);
			//OutputOfArray(a, length);

			//WriteLine("Array after the first element is deleted...");
			//DelElement_First(x);
			//OutputOfArray(a, n);

			//WriteLine("Array after the last element is deleted...");
			//DelElement_Last(x);
			//OutputOfArray(a, n);

			//WriteLine("Array after all elements are deleted...");
			//DelAllElement();
			//OutputOfArray(a, n);

			//WriteLine("Array after all negative elements are deleted...");
			//DelNegativeNumber();
			//OutputOfArray(a, n);

			//WriteLine("Array after all positive elements are deleted...");
			//DelPositiveNumber();
			//OutputOfArray(a, n);

			//WriteLine("Array after all even elements are deleted...");
			//DelEvenNumber();
			//OutputOfArray(a, n);

			//WriteLine("Array after all odd elements are deleted...");
			//DelOddNumber();
			//OutputOfArray(a, n);

			//WriteLine("Array after all prime elements are deleted...");
			//DelPrimeNumber();
			//OutputOfArray(a, n);

			//WriteLine("Array after all same elements are deleted...");
			//DelSameNumber();
			//OutputOfArray(a, n);

			//WriteLine("\nArray after the most element is deleted...");
			//DelTheMostNumber();
			//OutputOfArray(a, n);

			//WriteLine("\nArray after the less element is deleted...");
			//DelTheLessNumber();
			//OutputOfArray(a, n);

			//WriteLine("Enter the old element in the array: ");
			//x = int.Parse(ReadLine());
			//WriteLine("Enter the new element in the array: ");
			//y = int.Parse(ReadLine());
			//ChangeElement(x, y);
			//OutputOfArray(a, n);

			//WriteLine("The total number of positive number in the array is {0}", CountPositiveNumber());

			//WriteLine("The total number of negative number in the array is {0}", CountNegativeNumber());

			//WriteLine("The total number of prime number in the array is {0}", CountPrimeNumber());

			//WriteLine("The total number of even number in the array is {0}", CountEvenNumber());

			//WriteLine("The total number of even number in the array is {0}", CountOddNumber());

			//Write("\nEnter x to check: ");
			//x = int.Parse(ReadLine());
			//if (Check_X(x))
			//	WriteLine("\nExist !");
			//else
			//	WriteLine("\nDoes not exist !");

			//WriteLine("Array after ascending sort...");
			//SortIncreasing();
			//OutputOfArray(a, n);

			//WriteLine("Array after descending sort...");
			//SortDecreasing();
			//OutputOfArray(a, n);

			//WriteLine("Array after descending sort...");
			//ReverseArray();
			//OutputOfArray(a, n);
			//Read();
		}

		static void Creat()
		{
			Write("Enter the number of element in the array: ");
			n = int.Parse(ReadLine());
			WriteLine("Enter each element of the array...");
			for (int i = 0; i < n; i++)
			{
				Write("a[{0}] = ", i);
				a[i] = int.Parse(ReadLine());
			}
		}

		static int[] GeneratorRandomz(ref int n)
		{
			Write("Enter the number of element in the array: ");
			n = int.Parse(ReadLine());
			int[] a = new int[100];
			Random r = new Random();
			for (int i = 0; i < n; i++)
				a[i] = r.Next(-10, 10);
			return a;
		}

		static void OutputOfArray(int[] temp, int length)
		{
			WriteLine("\n");
			for (int i = 0; i < length; i++)
				Write(temp[i] + "\t");
			WriteLine("\nThe length of the array is {0}", length);
		}

		static void DelFirstX(int x)
		{
			DeleteAt(FindLocation(x));
		}

		static int FindLocation(int x)
		{
			for (int i = 0; i < n; i++)
				if (a[i] == x)
					return i;
			return -1;
		}

		static void DeleteAt(int location)
		{
			if (location == n - 1)
			{
				n--;
				return;
			}

			for (int i = location; i < n; i++)
				a[i] = a[i + 1];
			n--;
		}

		static int FinalPosition(int x)
		{
			for (int i = n - 1; i >= 0; i--)
				if (a[i] == x)
					return i;
			return -1;
		}

		static int SumOfIntegerArray()
		{
			int sum = 0;
			for (int i = 0; i < n; i++)
				sum += a[i];
			return sum;
		}

		static int Min()
		{
			int min = a[0];
			for (int i = 0; i < n; i++)
				if (min > a[i])
					min = a[i];
			return min;
		}

		static int Max()
		{
			int max = a[0];
			for (int i = 0; i < n; i++)
				if (max < a[i])
					max = a[i];
			return max;
		}

		static int[] NegativeNumbers(ref int rLength)
		{
			rLength = 0;
			int[] negativeNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (a[i] < 0)
				{
					negativeNumber[rLength] = a[i];
					rLength++;
				}
			}
			return negativeNumber;
		}

		static int[] PositiveNumbers(ref int rLength)
		{
			rLength = 0;
			int[] positiveNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (a[i] > 0)
				{
					positiveNumber[rLength] = a[i];
					rLength++;
				}
			}
			return positiveNumber;
		}

		static int[] EvenNumbers(ref int rLength)
		{
			rLength = 0;
			int[] evenNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (a[i] % 2 == 0)
				{
					evenNumber[rLength] = a[i];
					rLength++;
				}
			}
			return evenNumber;
		}

		static int[] OddNumbers(ref int rLength)
		{
			rLength = 0;
			int[] oddNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (a[i] % 2 != 0)
				{
					oddNumber[rLength] = a[i];
					rLength++;
				}
			}
			return oddNumber;
		}

		static bool IsPrimeNumber(int n)
		{
			if (n < 2)
				return false;
			for (int i = 2; i <= n / 2; i++)
				if (n % i == 0)
					return false;
			return true;
		}

		static int[] PrimeNumbers(ref int rLength)
		{
			rLength = 0;
			int[] primeNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (IsPrimeNumber(a[i]))
				{
					primeNumber[rLength] = a[i];
					rLength++;
				}
			}
			return primeNumber;
		}

		static int Occurrences(int x)
		{
			int count = 0;
			for (int i = 0; i < n; i++)
				if (a[i] == x)
					count++;
			return count;
		}

		static int TheMostOccurrences()
		{
			int max = -1;
			for (int i = 0; i < n; i++)
				if (Occurrences(a[i]) > max)
					max = Occurrences(a[i]);
			return max;
		}

		static int AtLeatsOccurrences()
		{
			int min = Occurrences(a[0]);
			for (int i = 0; i < n; i++)
				if (Occurrences(a[i]) < min)
					min = Occurrences(a[i]);
			return min;
		}

		static bool CheckContainElement(int[] b, int rLength, int x)
		{
			for (int i = 0; i < rLength; i++)
				if (b[i] == x)
					return true;
			return false;
		}

		static bool InsertAtTheEnd(int[] b, ref int length, int x)
		{
			length++;
			b[length - 1] = x;
			return true;
		}

		static int[] TheMost(ref int rLength)
		{
			rLength = 0;
			int theMost = TheMostOccurrences();
			int[] theMostNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (Occurrences(a[i]) == theMost && !CheckContainElement(theMostNumber, rLength, a[i]))
					InsertAtTheEnd(theMostNumber, ref rLength, a[i]);
			}
			return theMostNumber;
		}

		static int[] AtLeats(ref int rLength)
		{
			rLength = 0;
			int theLeats = AtLeatsOccurrences();
			int[] atLeatsNumber = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (Occurrences(a[i]) == theLeats && !CheckContainElement(atLeatsNumber, rLength, a[i]))
					InsertAtTheEnd(atLeatsNumber, ref rLength, a[i]);
			}
			return atLeatsNumber;
		}

		static int[] GreaterThanX(ref int rLength, int x)
		{
			rLength = 0;
			int[] greater = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (a[i] > x)
				{
					greater[rLength] = a[i];
					rLength++;
				}
			}
			return greater;
		}

		static int[] LesserThanX(ref int rLength, int x)
		{
			rLength = 0;
			int[] lesser = new int[100];

			for (int i = 0; i < n; i++)
			{
				if (a[i] < x)
				{
					lesser[rLength] = a[i];
					rLength++;
				}
			}
			return lesser;
		}

		static int[] ElementOfArray_Location(ref int rLength, int location, int amount)
		{
			rLength = 0;
			amount = 0;
			int[] elementOfAraay = new int[100];

			for (int i = location; i < n; i++)
			{
				elementOfAraay[rLength] = a[i];
				amount++;
				rLength++;
			}
			return elementOfAraay;
		}

		static bool ElementAdd_Location(int x, int location)
		{
			n++;
			for (int i = n - 1; i >= location; i--)
				a[i] = a[i - 1];
			a[location] = x;
			return true;
		}

		static bool ElementAdd_Top(int x)
		{
			n++;
			for (int i = n - 1; i >= 0; i--)
				a[i + 1] = a[i];
			a[0] = x;
			return true;
		}

		static bool ElementAdd_End(int x)
		{

			a[n++] = x;
			return true;
		}

		// Add array b to array a
		static bool AddAnArray_Top(int[] b, int rLength)
		{
			//int[] c = new int[a.Length + b.Length];

			//// Brings all source array elements to the beginning of the new array
			//for (int i = 0; i < b.Length; i++)
			//	c[i] = b[i];
			//// Inserts all target array elements after the source array
			//for (int i = 0; i < a.Length; i++)
			//	c[b.Length + i] = a[i];
			//a = c;
			// => [arr_B, arr_A]

			for (int i = rLength - 1; i >= 0; i--)
			{
				ElementAdd_Top(b[i]);
			}
			return true;
		}

		static bool AddAnArray_Last(int[] b, int rLength)
		{
			//int[] c = new int[a.Length + b.Length];

			//// Place all elements of the target array at the beginning of the source array
			//for (int i = 0; i < a.Length; i++)
			//	c[i] = a[i];

			//// Inserts all source array elements after the target array
			//for (int i = 0; i < b.Length; i++)
			//	c[a.Length + i] = b[i];
			//// => [arr_A, arr_B]
			//a = c;

			for (int i = 0; i < rLength; i++)
			{
				ElementAdd_End(b[i]);
			}
			return true;
		}

		static bool AddAnAraay_Location(int[] b, int rLength, int location)
		{
			//int[] c = new int[a.Length + b.Length];

			//// Brings the elements of the target array from position 0 to position 'location' at the beginning of array C
			//for (int i = 0; i < location; i++)
			//	c[i] = a[i];

			//// Inserts source array elements, starting at position 'location'
			//for (int i = 0; i < b.Length; i++)
			//	c[location + i] = b[i];

			//// Inserts the remaining elements of the target array
			//int k = 0;
			//for (int i = location; i < a.Length; i++)
			//{
			//	c[b.Length + location + k] = a[i];
			//	k++;
			//}
			//a = c;
			//// => [arr_A(0, position-1), arr_B, arr_A(position, lengthA-1)]

			for (int i = 0; i < rLength; i++)
			{
				ElementAdd_Location(b[i], location + i);
			}
			return true;
		}

		static bool CheckExist(int[] arr, int value)
		{
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] == value)
					return true;
			return false;
		}

		static int Count(int[] b)
		{
			int count = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (!CheckExist(b, a[i]))
				{
					count++;
				}
			}

			return count;
		}

		static int[] DeleteArrayInArray(int[] b, ref int rLength)
		{
			rLength = 0;

			// Counts the number of elements remaining in the array after deletion
			// If size is kept, it means that no elements are removed, always returned
			int size = Count(b);
			if (size == a.Length)
				return a;

			int[] c = new int[size];

			for (int i = 0; i < a.Length; i++)
			{
				if (!CheckExist(b, a[i]))
				{
					c[rLength] = a[i];
					rLength++;
				}
			}
			a = c;
			return a;
		}

		static bool DelElement_First(int location)
		{
			location = a[0];
			for (int i = 0; i < n - 1; i++)
				a[i] = a[i + 1];
			n--;
			return true;
		}

		static bool DelElement_Last(int locaiton)
		{
			locaiton = a[a.Length - 2];
			n--;
			return true;
		}

		static bool DelAllElement()
		{
			n = n - n;
			return true;
		}

		static bool DelNegativeNumber()
		{
			for (int i = 0; i < n; i++)
				if (a[i] < 0)
				{
					DeleteAt(i);
					i--;
				}
			return true;
		}

		static bool DelPositiveNumber()
		{
			for (int i = 0; i < n; i++)
				if (a[i] >= 0)
				{
					DeleteAt(i);
					i--;
				}
			return true;
		}

		static bool DelEvenNumber()
		{
			for (int i = 0; i < n; i++)
				if (a[i] % 2 == 0)
				{
					DeleteAt(i);
					i--;
				}
			return true;
		}

		static bool DelOddNumber()
		{
			for (int i = 0; i < n; i++)
				if (a[i] % 2 != 0)
				{
					DeleteAt(i);
					i--;
				}
			return true;
		}

		static bool DelPrimeNumber()
		{
			for (int i = 0; i < n; i++)
				if (IsPrimeNumber(a[i]))
				{
					DeleteAt(i);
					i--;
				}
			return true;
		}

		static bool DelSameNumber()
		{
			for (int i = 0; i < n - 1; i++)
				for (int j = i + 1; j < n; j++)
					if (a[i] == a[j])
					{
						DeleteAt(j);
					}
			return true;
		}

		static bool DelSameX(int x)
		{
			for (int i = 0; i < n; i++)
			{
				if (a[i] == x)
				{
					DeleteAt(i);
				}
			}
			return true;
		}

		static void RemoveElements(int[] arr, int n, int k)
		{
			// Hash map which will store the 
			// frequency of the elements of the array. 
			Dictionary<int, int> mp = new Dictionary<int, int>();

			for (int i = 0; i < n; ++i)
			{
				// Incrementing the frequency 
				// of the element by 1. 
				if (mp.ContainsKey(arr[i])) // Nếu bên trong dictionary đã có số này rồi thì mình cộng số lần xuất hiện của nó lên
					mp[arr[i]]++;
				else
					mp[arr[i]] = 1; // Nếu bên trong dictionary chưa có số này thì mình gán số lần xuất hiện của nó bằng 1
			}

			// Hiểu đơn giản thì mình dùng cái dictionary này để lưu trữ số lần xuất hiện của 1 số tương ứng
			// Lưu trữ dưới dạng key: value
			// Key ở đây tượng trưng cho 1 số trong mảng
			// Value ở đây là số lần xuất hiện của nó

			// Để lấy value của 1 key bất kỳ, mình truy cập giống như mảng: value = dictionary[key]
			// Trong trường hợp này, muốn lấy số lần xuất hiện của số 1 thì mình làm
			// soLanXuatHien = mp[1] => soLanXuatHien = 3.

			// từ từ mình sẽ tiếp cận với các dạng cấu trúc lưu trữ dữ liệu khác
			// ví dụ như danh sách (list), map
			// lưu trữ theo dạng key - value như này phổ biến lắm á, sau này em học về cơ sở dữ liệu
			// mình có 2 trường phái chính
			// 1 - cơ sở dữ liệu quan hệ - lưu trữ dữ liệu theo bảng, theo từng hàng, quan hệ các bảng
			// 2 - cơ sở dữ liệu phi quan hệ - lưu trữ dữ liệu trong đối tượng, theo dạng key - value

			// Mình sẽ học cơ sở dữ liệu quan hệ
			// Cơ sử dữ liệu phi quan hệ tự tìm hiểu, dùng khá phổ biến. Em tìm hiểu về Google Firebase, MongoDB, chung chung là NoSQL

			// nhưng mà làm xong cũng chẳng thấy nó tối ưu hơn bao nhiêu nhể
			// phiền phức thêm

			// Chỗ này mình sẽ có 1 cấu trúc dữ liệu mới tên là dictionary
			// thật ra nó lưu trữ theo dạng key - value

			n = 0;
			for (int i = 0; i < n; ++i)
			{
				// Print the element which appear 
				// less than or equal to k times. 
				if (mp.ContainsKey(arr[i]) && mp[arr[i]] <= k)
				{
					// Console.Write(arr[i] + " ");
					a[n++] = arr[i];
				}
			}
		}

		static bool DelTheMostNumber()
		{
			int theMost = TheMostOccurrences();

			//int[] c = new int[n];

			//int k = 0;
			//for (int i = 0; i < n; i++)
			//{
			//	if (Occurrences(a[i]) != theMost)
			//		c[k++] = a[i];
			//}

			//a = c;
			//n = k;

			int k = 0;
			while (k < n)
			{
				if (Occurrences(a[k]) == theMost)
				{
					DelSameX(a[k]);

					if (k > 0)
						k--;
					else
						k = 0;

				}
				else k++;
			}

			return true;
		}

		static bool DelTheLessNumber()
		{
			int atLeats = AtLeatsOccurrences();

			// dạng key - value phổ biến cực
			// nếu học web thì mình sẽ có format json để trao đổi dữ liệu giữa client với server, cũng lưu trữ dạng key - value :v

			// mình có 2 hướng
			// hướng đầu tiên là tạo mảng mới, thêm những thằng có số lần xuất hiện ít hơn themost vào, sau đó gán mảng a bằng mảng mới
			// hướng thứ 2 là dùng hàm delsame để xóa trực tiếp trên mảng a luôn

			/*
			int[] tmp = new int[n];

			int k = 0;
			for (int i = 0; i < n; i++)
			{
				if (Occurrences(a[i]) != minOccurence) tmp[k++] = a[i];
			}

			a = tmp;
			n = k;
			*/

			int k = 0;
			while (k < n)
			{
				if (Occurrences(a[k]) == atLeats)
				{
					DelSameX(a[k]);
					if (k > 0)
						k--;
					else k = 0;

				}
				else k++;
			}
			return true;
		}

		static bool ChangeElement(int Old, int New)
		{
			for (int i = 0; i < n; i++)
			{
				if (a[i] == Old)
				{
					int index = i;
					for (int j = index + 1; j < n; j++)
					{
						a[i] = a[i + 1];
					}
					a[index] = New;
				}
			}
			return true;
		}

		static int CountPositiveNumber()
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (a[i] > 0)
					count++;
			}
			return count;
		}

		static int CountNegativeNumber()
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (a[i] < 0)
					count++;
			}
			return count;
		}

		static int CountPrimeNumber()
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (IsPrimeNumber(a[i]))
					count++;
			}
			return count;
		}

		static int CountEvenNumber()
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (a[i] % 2 == 0)
					count++;
			}
			return count;
		}

		static int CountOddNumber()
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (a[i] % 2 != 0)
					count++;
			}
			return count;
		}

		static bool Check_X(int x)
		{
			for (int i = 0; i < n; i++)
				if (a[i] == x)
					return true;
			return false;
		}

		static void SortIncreasing()
		{
			for (int i = 0; i < n - 1; i++)
				for (int j = i + 1; j < n; j++)
					if (a[i] > a[j])
					{
						int temp = a[i];
						a[i] = a[j];
						a[j] = temp;
					}
		}

		static void SortDecreasing()
		{
			for (int i = 0; i < n - 1; i++)
				for (int j = i + 1; j < n; j++)
					if (a[i] < a[j])
					{
						int temp = a[i];
						a[i] = a[j];
						a[j] = temp;
					}
		}

		static void ReverseArray()
		{
			for (int i = 0; i < n / 2; i++)
			{
				int temp = a[i];
				a[i] = a[n - 1 - i];
				a[n - 1 - i] = temp;
			}
		}
	}
}
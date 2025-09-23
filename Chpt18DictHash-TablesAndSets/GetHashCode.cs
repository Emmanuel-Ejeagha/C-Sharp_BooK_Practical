// using System;

// namespace Chpt18DictHash_TablesAndSets;

// public class HashCode
// {
//     public override unsafe int GetHashCode()
//     {
//         fixed (char* str = ((char*)this))
//         {
//             char* chPtr = str;
//             int num = 352654597;
//             int num2 = num;
//             int* numPtr = (int*)chPtr;
//             for (int i = this.Length; i > 0; i -= 4)
//             {
//                 num = (((num << 5) + num) + (num >> 27)) ^ numPtr[0];
//                 if (i <= 2)
//                 {
//                     break;
//                 }
//                 num2 = (((num2 << 5) + num2) + (num2 >> 27)) ^ numPtr[1];
//             }
//             return (num + (num2 * 1566083941));
//         }
//     }

//     public override int GetHashCode()
//     {
//         return 42;
//     }
// }

﻿using System;

namespace 空心菱形
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; j <= 4; i++)
                for (var j = 1; j <= 4 - i; j++)
                {
                    document.write('&nbsp;&nbsp;');
                }
            for (var j = 1; j <= 2i - 1；j++)
            {
                if (j == 1 || j == 2i - 1)
                        {
                document.write('*')
                        }
            else
            {
                document.write('&nbsp;&nbsp;')
            }
            for (var i = 3; j >= 1; i--) {
                for (var j = 1; j <= 4 - i; j++) {
                    document.write('&nbsp;&nbsp;')
            }
                for (var j = 1; j <= 2i - 1；j++)
                    if (j == 1 || j == 2 * i - 1) { 
                        if (j == 1 || j == 2i - 1){
                document.write('*')
            }else
            {
                document.write('&nbsp;')
            }
    }
        document.write('<br>')
}

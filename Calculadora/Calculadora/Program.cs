﻿using System.ComponentModel;

namespace Calcula {
    class Program {
        static void Main(string[] args) {


            double x;
            double y;
            double soma = 0;

            scanf("%d", &x);
            scanf("%d", &y);

            if(x > y) {
                for(int i = y + 1; i < x; i++) {
                    if(i % 2 != 0) {
                        soma = soma + i;
                    }
                }

            }else if(x < y) {
                for (int i = x + 1; i < y; i++) {
                    if (i % 2 != 0) {
                        soma = soma + i;
                    }
                }
            }
            else {
                printf("0");
            }

            printf("soma = %0.2lf", soma);

        }

    }
}
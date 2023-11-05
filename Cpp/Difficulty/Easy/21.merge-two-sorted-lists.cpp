#include <string>

namespace easy{

    int romanToInt(std::string s) {
        enum values { M = 1000, D = 500, C = 100, L = 50, X = 10, V = 5, I = 1 };

        int prev_val = 0;
        int sum_total = 0;

        for (int i = s.length()-1; i >= 0; i--) {
            switch (s[i]) {
            case 77:
                if (prev_val > M) {
                    sum_total -= M;
                }
                else {
                    sum_total += M;
                }
                prev_val = M;
                break;

            case 68:
                if (prev_val > D) {
                    sum_total -= D;
                }
                else {
                    sum_total += D;
                }
                prev_val = D;
                break;

            case 67:
                if (prev_val > C) {
                    sum_total -= C;
                }
                else {

                    sum_total += C;
                }
                prev_val = C;
                break;

            case 76:

                if (prev_val > L) {
                    sum_total -= L;
                }
                else {
                    sum_total += L;
                }
                prev_val = L;
                break;

            case 88:

                if (prev_val > X) {
                    sum_total -= X;
                }
                else {
                    sum_total += X;
                }
                prev_val = X;
                break;

            case 86:

                if (prev_val > V) {
                    sum_total -= V;
                }
                else {
                    sum_total += V;
                }
                prev_val = V;
                break;
            case 73:

                if (prev_val > I) {
                    sum_total -= I;
                }
                else {
                    sum_total += I;
                }
                prev_val = I;
                break;
            }
        }

        return sum_total;
    }





}



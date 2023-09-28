#include "easy_TwoSum.h"

vector<int> TwoSumsHelper(vector<int> vect, int target) {
	vector<int> temp;

	for (int i = 0; i < vect.size() - 1; i++) {
		//std::cout << "i: " << i << " value: " << vect.at(i) << std::endl;
		int targetValue = target - vect.at(i);
		temp.push_back(i);

		for (int j = i + 1; j < vect.size(); j++) {
			//std::cout << "j: " << j << " value: " << vect.at(j) << " ";
			if (vect.at(j) == targetValue) {
				temp.push_back(j);
				return temp;
			}
		}
		temp.clear();
	}
	return temp;
}

void TwoSums() {
	vector<int> nums;
	nums.push_back(2);
	nums.push_back(7);
	nums.push_back(11);
	nums.push_back(6);
	nums.push_back(48);
	nums.push_back(21);
	nums.push_back(11);
	nums.push_back(14);


	int	target = 35;

	vector<int> indicies = TwoSumsHelper(nums, target);

	for (const int x : indicies) {
		cout << x << endl;
	}
}


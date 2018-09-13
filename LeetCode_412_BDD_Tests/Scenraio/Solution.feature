#language: zh-TW
功能: FizzBuzzLibTests

場景: 呼叫GetResult方法並傳入2，結果應為長度2的字串集合
	假設 陣列長度輸入 2 
	當   呼叫GetResult方法
	那麼 結果為
	| value |
	| 1     |
	| 2     |

場景: 呼叫GetResult方法並傳入3，結果應為長度3的字串集合，且三的倍數應為Fizz
	假設 陣列長度輸入 3 
	當   呼叫GetResult方法
	那麼 結果為
	| value  |
	| 1      |
	| 2      |
	| Fizz   |

場景: 呼叫GetResult方法並傳入5，結果應為長度5的字串集合，且三的倍數應為Fizz，五的倍數應為Buzz
	假設 陣列長度輸入 5
	當   呼叫GetResult方法
	那麼 結果為
	| value |
	| 1     |
	| 2     |
	| Fizz  |
	| 4     |
	| Buzz  |

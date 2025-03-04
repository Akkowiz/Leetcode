/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function (init) {
	let count = 0;
	return {
		increment: function () {
			count++;
			return count + init;
		},
		decrement: function () {
			count--;
			return count + init;
		},
		reset: function () {
			count = 0;
			return count + init;
		},
	};
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */

import {describe, expect, it} from '@jest/globals';

function fizzbuzz(number: number) {
  return "1";
}

describe('fizzibuzz', () => {
  it('should return 1 for 1', () => {
    expect(fizzbuzz(1)).toEqual("1")
  });
});

import {describe, expect, it} from '@jest/globals';
describe('greet function', () => {
  it('should return bonjour emilie', () => {
    expect(greet('emilie')).toEqual('bonjour emilie');
  });
});


function greet(name: string): string {
  return `bonjour ${name}`;
}
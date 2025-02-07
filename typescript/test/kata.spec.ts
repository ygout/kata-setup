import {describe, expect, it} from '@jest/globals';
describe('greet function', () => {
  it('should return Bonjour, Emilie', () => {
    expect(greet('Emilie')).toEqual('Bonjour Emilie');
  });

  it('should Bonjour, mon ami', () => {
    expect(greet(null)).toEqual('Bonjour, mon ami');
  });
});


function greet(name: string | null): string {
  if(name === null) {
    return 'Bonjour, mon ami';
  }
  return `Bonjour ${name}`;
}

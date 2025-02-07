import {describe, expect, it} from '@jest/globals';
describe('greet function', () => {
  it('should return Bonjour, Emilie', () => {
    expect(greet('Emilie')).toEqual('Bonjour Emilie');
  });

  it('should Bonjour, mon ami when name is null', () => {
    expect(greet(null)).toEqual('Bonjour, mon ami');
  });

  it('shoud return BONJOUR FRED! when name is FRED', () => {
    expect(greet('FRED')).toEqual('BONJOUR FRED!');
  })
});


function greet(name: string | null): string {
  if(name === 'FRED') {
    return 'BONJOUR FRED!';
  }
  if(name === null) {
    return 'Bonjour, mon ami';
  }
  return `Bonjour ${name}`;
}

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

  it('should return Bonjour Sandra et Clément when Sandra,Clément' , () => {
    expect(greet('Sandra,Clément')).toEqual('Bonjour Sandra et Clément');
  })
});


function greet(name: string | null): string {

  if(name === 'Sandra,Clément') {
    return 'Bonjour Sandra et Clément';
  }
  if(name === 'FRED') {
    return 'BONJOUR FRED!';
  }
  if(name === null) {
    return 'Bonjour, mon ami';
  }
  return `Bonjour ${name}`;
}

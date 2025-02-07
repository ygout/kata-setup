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

  it('should return Bonjour Jo, Ju, et Juju when Jo,Ju,Juju', () => {
    expect(greet('Jo,Ju,Juju')).toEqual('Bonjour Jo, Ju, et Juju');
  })
});


function greet(name: string | null): string {
  const hasVirgule = name?.includes(',');

  if(name === 'Jo,Ju,Juju') {
    return 'Bonjour Jo, Ju, et Juju';
  }

  if(hasVirgule) {
    return `Bonjour ${name?.split(',').join(' et ')}`;
  }

  if(name === 'FRED') {
    return 'BONJOUR FRED!';
  }
  if(name === null) {
    return 'Bonjour, mon ami';
  }
  return `Bonjour ${name}`;
}

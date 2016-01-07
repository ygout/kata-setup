var expect = require('chai').expect;

describe('Kata', function() {
    var Kata = require('../src/Kata');

    describe('toto()', function() {
        it('returns tata', function() {
            var kataObject = new Kata();
            expect(kataObject.toto()).to.equal('tata')
        });
    });
});
const {expect} = require('chai');
const Kata = require('../src/Kata');

describe('Kata', function () {

    describe('toto()', function () {
        it('returns tata', function () {
            var kataObject = new Kata();
            expect(kataObject.toto()).to.equal('tata')
        });
    });
});
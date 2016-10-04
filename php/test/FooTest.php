<?php
//namespace kata;

use PHPUnit\Framework\TestCase;

class FooTest extends TestCase {
    
    public function testFailure() {
        $foo = new Foo();
        $this->assertEquals(1, 2);
    }
    
}


?>

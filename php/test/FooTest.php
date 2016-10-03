<?php

use PHPUnit\Framework\TestCase;


class FooTest extends TestCase {
    
    public function testFailure() {
        $this->assertEquals(1, 2);
    }
    
}

?>

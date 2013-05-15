package kata;

import static org.fest.assertions.api.Assertions.assertThat;

import org.junit.Test;

public class KataTest {

    @Test
    public void whenFooIsCalled_thenItReturnsBar() {
        assertThat(new Foo().foo()).isEqualTo("qix");
    }
}

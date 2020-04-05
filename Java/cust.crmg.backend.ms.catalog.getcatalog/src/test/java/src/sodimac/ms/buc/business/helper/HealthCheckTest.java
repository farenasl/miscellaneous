package src.personalproject.ms.personalproject.business.helper;

import static org.junit.Assert.assertEquals;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.InjectMocks;
import org.mockito.Mockito;
import org.mockito.MockitoAnnotations;

import org.springframework.test.context.junit4.SpringRunner;

import org.springframework.boot.actuate.health.Health;

/**
 * @author FArenasL (fabian.arenas.l@gmail.com)
 * @version 1.0
 * @created 17-dic-2019 09:00
 */
@RunWith(SpringRunner.class)
public class HealthCheckTest {
    @InjectMocks
    private HealthCheck hck;

    @Before
    public void before() {
        MockitoAnnotations.initMocks(this);
    }

    @Test
    public void testHealthOK() {
        assertEquals(Health.up().build(), this.hck.health());
    }

    @Test
    public void testHealthError() {
        HealthCheck temp = new HealthCheck();
        HealthCheck spyTemp = Mockito.spy(temp);
    
        Mockito.doReturn(1).when(spyTemp).check();
        Health actual = spyTemp.health();

        assertEquals(Health.down().withDetail("Error Code", 1).build(), actual);
    }

    @Test
    public void testCheck() {
        assertEquals(0, this.hck.check());
    }
}
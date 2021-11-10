import HelloWorld from '@/components/HelloWorld.vue'
import {render} from "@testing-library/vue"

describe('HelloWorld.vue', () => {
  it('renders props.msg when passed', () => {
    const msg = 'new message'
    const component = render(HelloWorld, {
      propsData: { msg }
    })
    component.getByText(msg)
  })
})

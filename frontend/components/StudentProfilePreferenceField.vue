<template>
	<div :class="`preference-field ${this.size}`">
    <div class="preference-field__info">
      <h3 class="preference-field__title">{{ skill?.title }}</h3>
      <p>{{skill?.description}}</p>
    </div>
    <NImage width="100" height="100" :src="skill?.imageURL"/>
	</div>
</template>

<script lang="ts">

import {defineComponent, PropType} from "vue";
import {NImage} from "naive-ui";

enum Size {
  small,
  large
}

export default defineComponent({
  components: {
    NImage
  },
	props: {
    skill: {
      type: Object as PropType<Skill>
    },
    size: {
      type: Number as PropType<Size>,
      default: 'large'
    },
	}
})
</script>

<style scoped>
.preference-field {
	background-color: var(--color-white);
	border-radius: 3px;
	-webkit-box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05); 
	box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);

  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: flex-start;
  padding: 25px;
  gap: 10px;
  flex-grow: 1;
  flex-basis: 0;
}
.preference-field.small {
  flex-direction: column-reverse;
  align-items: center;
  justify-content: flex-end;
}
.preference-field__info {
  display: flex;
  flex-direction: column;
  gap: 3px;
}
.preference-field__title {
	font-size: 1.2rem;
}

@media (min-width: 640px) {
	.preference-field__title {
		font-size: 1.5rem;
	}
}

</style>
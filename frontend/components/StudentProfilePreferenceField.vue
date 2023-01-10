<template>
	<div :class="`preference-field ${this.size}`">
    <div class="preference-field__info">
      <h3 class="preference-field__title">{{ skill?.title }}</h3>
      <p>{{skill?.description}}</p>
    </div>
    <NImage :width="preferenceFieldImageSize" :height="preferenceFieldImageSize" :src="skill?.imageURL"/>
	</div>
</template>

<script lang="ts">

import {defineComponent, PropType} from "vue";
import {NImage} from "naive-ui";

type Size = 'small' | 'medium' | 'large'

export default defineComponent({
  components: {
    NImage
  },
	props: {
    skill: {
      type: Object as PropType<Skill>
    },
    size: {
      type: String as PropType<Size>,
      default: 'large'
    },
	},
  computed: {
    preferenceFieldImageSize() {
      if (this.size === 'small') {
        return 168
      }
      if (this.size === 'medium') {
        return 150
      }
      else return 100
    }
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
  font-size: 14px;
}
.preference-field.small {
  flex-direction: row;
  align-items: center;
  justify-content: flex-end;
}
.preference-field__info {
  display: flex;
  flex-direction: column;
  gap: 3px;
  flex-grow: 1;
  flex-basis: 0;
}
.preference-field__title {
	font-size: 1.2rem;
  word-break: break-word;
}
@media (min-width: 640px) {
	.preference-field__title {
		font-size: 1.25rem;
	}
  .preference-field {
    max-width: calc(100% - 50px);
  }
}
@media (min-width: 1024px) {
  .preference-field.small {
    max-width: calc(50% - 60px);
    flex-direction: column-reverse;
  }
}
@media (min-width: 1280px) {
  .preference-field {
    max-width: unset;
  }
}

</style>
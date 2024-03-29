<template>
    <div class="questionnaire-item__card" :class="this.size, {selected: selected}">
      <div class="questionnaire-item__card__info">
        <h3 class="questionnaire-item__card__title">{{ skill?.title }}</h3>
        <p class="questionnaire-item__card__description">{{skill?.description}}</p>
      </div>
      <NImage :width="preferenceFieldImageSize" :height="preferenceFieldImageSize" :src="skill?.imageURL" preview-disabled/>
    </div>
</template>

<script lang="ts">

import {defineComponent, PropType, ref} from "vue";
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
    selectable: {
      type: Boolean,
      default: false
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
  },
  setup() {
    const selected = ref(false)
    const toggleSelected = () => {
      selected.value = !selected.value
    }

    return {
      toggleSelected,
      selected
    }
  }
})
</script>

<style scoped>
.questionnaire-item__card {
  --padding: 25px;
	background-color: var(--color-white);
	border-radius: 3px;
	-webkit-box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);
	box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: flex-start;
  padding: var(--padding);
  gap: 10px;
  flex-grow: 1;
  flex-basis: 0;
  font-size: 14px;
  text-align: start;
  height: calc(100% - 2 * var(--padding));
}
.questionnaire-item__card.small {
  flex-direction: row;
  align-items: center;
  justify-content: flex-end;
}
.questionnaire-item__card.selected {
  outline: 2px solid #666666;
}
.questionnaire-item__card:hover {
  background: #FADB7D;
  cursor: pointer
}
.questionnaire-item__card__info {
  display: flex;
  flex-direction: column;
  gap: 3px;
  flex-grow: 1;
  flex-basis: 0;
}
.questionnaire-item__card__title {
	font-size: 1.2rem;
  line-height: 1.5rem;
  word-break: break-word;
  font-weight: 700;
}
.questionnaire-item__card__description {
  line-height: 1.25rem;
}
@media (min-width: 640px) {
	.questionnaire-item__card__title {
		font-size: 1.25rem;
	}
  .questionnaire-item__card {
    max-width: calc(100% - 2 * var(--padding));
  }
}
@media (min-width: 1024px) {
  .questionnaire-item__card.small {
    flex-direction: column-reverse;
  }
}
@media (min-width: 1280px) {
  .questionnaire-item__card.small {
    max-width: unset;
  }
}

</style>
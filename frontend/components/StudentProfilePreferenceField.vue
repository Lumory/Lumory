<template>
	<div class="preference-field">
		<h3 class="preference-field__title">{{ title }}</h3>
		<n-button strong color="#FEBF00" text-color="#00000">Bekijken</n-button>
	</div>
</template>

<script lang="ts">
import { NButton } from "naive-ui";

export default {
	components: {
		NButton
	},
	props: {
		title: String,
	}
}
</script>

<style scoped>
.preference-field {
	background-color: var(--color-white);
	border-radius: 3px;
	-webkit-box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05); 
	box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);
	padding: 25px;

	display: flex;
	align-items: center;
	justify-content: space-between;
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
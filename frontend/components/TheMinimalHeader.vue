<template>
	<Container>
		<n-grid :cols="3" class="grid--position">
			<n-gi justify="center" class="back-button--position">
				<NuxtLink to="/" class="back-text--centering">
					<h5>&lt; Terug naar start</h5>
				</NuxtLink>
			</n-gi>
			<n-gi class="grid__item--center">
				<NuxtLink to="/">
					<img
						class="logo--size"
						src="~/assets/img/logo.svg"
						alt="Lumory logo"
					/>
				</NuxtLink>
			</n-gi>
			<n-gi />
		</n-grid>
	</Container>
</template>

<script lang="ts">
import { NGrid, NGi } from 'naive-ui';
export default defineComponent({
	components: {
		NGrid,
		NGi,
	},
});
</script>

<style scoped>
.grid--position {
	padding-top: 20px;
	min-height: 80px;
	max-width: 1200px;
}

.grid__item--center {
	display: flex;
	justify-content: center;
	align-items: center;
}
.back-button--position {
	display: flex;
	align-items: center;
}
.logo--size {
	height: 60px;
	width: auto;
}
.back-text--centering {
	text-align: center;
}
</style>

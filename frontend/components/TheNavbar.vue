<template>
	<nav class="navbar">
		<div class="navbar__logo navbar__item">
			<img
				class="navbarLogo__img"
				src="~/assets/img/Logo horizontal.svg"
				alt="Logo Lumory"
			/>
		</div>
		<div class="navbar__links navbar__item" @click="menuShow = !menuShow">
			<svg
				class="navbar__burger"
				xmlns="http://www.w3.org/2000/svg"
				xmlns:xlink="http://www.w3.org/1999/xlink"
				viewBox="0 0 24 24"
			>
				<path
					class="navbar__burger--color"
					d="M4 18h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zm0-5h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zM3 7c0 .55.45 1 1 1h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1z"
					fill="currentColor"
				></path>
			</svg>
		</div>
	</nav>
	<div v-show="menuShow" class="mobileNavbar__overlay">
		<div class="mobileNavbar__overlayHeader">
			<img
				class="navbarLogo__img"
				src="~/assets/img/Logo horizontal.svg"
				alt="Logo Lumory"
			/>
			<div>
				<svg
					xmlns="http://www.w3.org/2000/svg"
					xmlns:xlink="http://www.w3.org/1999/xlink"
					viewBox="0 0 24 24"
				>
					<path
						d="M19 6.41L17.59 5L12 10.59L6.41 5L5 6.41L10.59 12L5 17.59L6.41 19L12 13.41L17.59 19L19 17.59L13.41 12z"
						fill="currentColor"
					></path>
				</svg>
			</div>
		</div>
		<div>a</div>
		<div>a</div>
		<div>a</div>
		<div>a</div>
		<div>a</div>
	</div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
	data() {
		return {
			menuShow: false,
		};
	},
});
</script>

<style scoped>
.navbar {
	width: 100vw;
	height: auto;
	min-height: 64px;
	background-color: var(--color-background-one);

	display: flex;
	justify-content: space-between;
}
.navbar__item {
	padding-left: 20px;
	padding-right: 20px;
}
.navbar__logo,
.navbar__links {
	display: flex;
	justify-content: center;
	align-items: center;
}
.navbarLogo__img {
	height: 20px;
}
.navbar__burger {
	width: 30px;
	height: 30px;
}
.navbar__burger--color {
	color: var(--color-white);
}

.mobileNavbar__overlay {
	width: 100vw;
	height: 100vh;
	background-color: orange;
	position: fixed;
	overflow: hidden;
	top: 0;

	display: flex;
	flex-direction: column;
}
.mobileNavbar__overlayHeader {
	display: flex;
}
</style>

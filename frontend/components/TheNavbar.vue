<template>
	<div>
		<div class="navbarContainer">
			<nav class="navbar">
				<div class="navbar__logo navbar__item">
					<NuxtLink to="/">
						<img
							class="navbarLogo__img"
							src="~/assets/img/Logo horizontal.svg"
							alt="Logo Lumory"
						/>
					</NuxtLink>
				</div>
				<div class="links navbar__item">
					<NuxtLink class="nuxtLink" to="/student">
						<div class="links__item --white">studenten</div>
					</NuxtLink>
					<NuxtLink class="nuxtLink" to="/stagebedrijf">
						<div class="links__item --white">stagebedrijven</div>
					</NuxtLink>
					<NuxtLink class="nuxtLink" to="/werkgever">
						<div class="links__item --white">werkgevers</div>
					</NuxtLink>
					<NuxtLink class="nuxtLink" to="/signin">
						<div class="links__item --white">inloggen</div>
					</NuxtLink>
					<n-space>
						<NuxtLink to="signup" @show="!menuShow">
							<n-button
								:focusable="true"
								color="#FFFFFF"
								text-color="Black"
								round
								>Registreren</n-button
							>
						</NuxtLink>
					</n-space>
				</div>
				<div
					tabindex="0"
					@keyup.enter="menuShow = !menuShow"
					class="navbar__menu navbar__item"
					@click="menuShow = !menuShow"
				>
					<svg
						class="navbar__burger"
						xmlns="http://www.w3.org/2000/svg"
						xmlns:xlink="http://www.w3.org/1999/xlink"
						viewBox="0 0 24 24"
					>
						<path
							class="navbar__menuImage--white"
							d="M4 18h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zm0-5h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zM3 7c0 .55.45 1 1 1h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1z"
							fill="currentColor"
						/>
					</svg>
				</div>
			</nav>
		</div>
		<div v-show="menuShow" class="mobileNavbar__overlay">
			<div class="mobileNavbar__overlayHeader">
				<div class="navbar__logo">
					<img
						class="navbarLogo__img navbar__item"
						src="~/assets/img/Logo horizontal.svg"
						alt="Logo Lumory"
					/>
				</div>
				<div class="navbar__menu">
					<svg
						tabindex="0"
						@keyup.enter="menuShow = !menuShow"
						class="navbar__close navbar__item"
						@click="menuShow = !menuShow"
						xmlns="http://www.w3.org/2000/svg"
						xmlns:xlink="http://www.w3.org/1999/xlink"
						viewBox="0 0 24 24"
					>
						<path
							class="navbar__menuImage--white"
							d="M19 6.41L17.59 5L12 10.59L6.41 5L5 6.41L10.59 12L5 17.59L6.41 19L12 13.41L17.59 19L19 17.59L13.41 12z"
							fill="currentColor"
						/>
					</svg>
				</div>
			</div>
			<NuxtLink
				to="/signup"
				@click="menuShow = !menuShow"
				class="link--styling --white"
				><div class="navbarOverlay__item">Registreren</div></NuxtLink
			>
			<NuxtLink
				to="/signin"
				@click="menuShow = !menuShow"
				class="link--styling --white"
				><div class="navbarOverlay__item">Inloggen</div></NuxtLink
			>
			<NuxtLink
				to="/student"
				@click="menuShow = !menuShow"
				class="link--styling --white"
				><div class="navbarOverlay__item">Voor studenten</div></NuxtLink
			>
			<NuxtLink
				to="/stagebedrijf"
				@click="menuShow = !menuShow"
				class="link--styling --white"
				><div class="navbarOverlay__item">Voor stagebedrijven</div></NuxtLink
			>
			<NuxtLink
				to="/werkgever"
				@click="menuShow = !menuShow"
				class="link--styling --white"
				><div class="navbarOverlay__item">Voor werkgevers</div></NuxtLink
			>

			<!-- <NuxtLink
					to="/werkgever"
					@click="menuShow = !menuShow"
					class="link--styling --white"
					>Voor werkgevers</NuxtLink
				> -->
		</div>
	</div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import { NButton, NSpace } from 'naive-ui';

export default defineComponent({
	data() {
		return {
			menuShow: false,
		};
	},
	components: {
		NButton,
		NSpace,
	},
});
</script>

<style scoped>
.navbarContainer {
	width: 100vw;
	height: auto;
	min-height: 64px;
	background-color: var(--color-background-one);
	display: flex;
	justify-content: center;
}
.navbar {
	width: 100%;
	max-width: 1200px;
	height: auto;

	display: flex;
	justify-content: space-between;
}
.links {
	display: none;
	gap: 20px;
}
.nuxtLink {
	text-decoration: none;
}
.nuxtLink,
.links__item {
	height: 100%;
}
.links__item {
	display: flex;
	justify-content: center;
	align-items: center;
}
.links__item:hover {
	box-sizing: border-box;
	-moz-box-sizing: border-box;
	-webkit-box-sizing: border-box;
	border-bottom: 2px solid orange;
	height: calc(100% - 2px);
	margin-top: 2px;
	cursor: pointer;
}
.navbar__item {
	padding-left: 20px;
	padding-right: 20px;
}
.navbar__logo,
.navbar__menu {
	display: flex;
	justify-content: center;
	align-items: center;
}
.navbarLogo__img {
	height: 20px;
	width: auto;
}
.navbar__burger,
.navbar__close {
	width: 30px;
	height: 30px;
}

[class$='--white'] {
	color: white;
}

.mobileNavbar__overlay {
	width: 100vw;
	height: 100vh;
	background-color: var(--color-background-one);
	position: fixed;
	overflow: hidden;
	top: 0;

	display: flex;
	flex-direction: column;
	gap: 5px;
}
.mobileNavbar__overlayHeader {
	display: flex;
	justify-content: space-between;
	align-content: center;
	height: 64px;
	max-height: 64px;
}
.navbarOverlay__item {
	height: calc(60vh / 5);
	display: flex;
	align-items: center;
	justify-content: flex-end;
	font-family: 'Raleway', sans-serif;
	margin-right: 30px;
}
.link--styling {
	text-decoration: none;
}

/* Media queries */
@media (min-width: 1024px) {
	.navbar__menu {
		display: none;
	}
	.navbar {
		min-height: 80px;
	}
	.links {
		display: flex;
		justify-content: center;
		align-items: center;
	}
	.navbarLogo__img {
		height: 30px;
		width: auto;
	}
}
</style>

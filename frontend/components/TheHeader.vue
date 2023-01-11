<template>
	<Container class="container">
		<NuxtLink to="/"><img class="long-logo--size logo" src="~/assets/img/Logo-horizontal.svg" alt="Lumory logo"></NuxtLink>
		<svg class="burger-menu icon--size" @click="showMenu = !showMenu" tabindex="0" aria-labelledby="title" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 0 512 512">
			<title>Mobile menu</title>
			<path fill="none" stroke="currentColor" stroke-linecap="round" stroke-miterlimit="10" stroke-width="48" d="M88 152h336"></path>
			<path fill="none" stroke="currentColor" stroke-linecap="round" stroke-miterlimit="10" stroke-width="48" d="M88 256h336"></path>
			<path fill="none" stroke="currentColor" stroke-linecap="round" stroke-miterlimit="10" stroke-width="48" d="M88 360h336"></path>
		</svg>
		<nav class="navigation">
			<NuxtLink to="/student" class="navigation__link">Studenten</NuxtLink>
			<NuxtLink to="/stagebedrijf" class="navigation__link">Stagebedrijven</NuxtLink>
			<NuxtLink to="/werkgever" class="navigation__link">Werkgevers</NuxtLink>
			<div v-show="useCookie('user').value === undefined" class="navigation__logged-out">
				<NuxtLink to="/signin" class="navigation__link">Log in</NuxtLink>
				<n-space>
					<NuxtLink to="/signup">
						<n-button class="navigation__register-button" secondary round>Registreren</n-button>
					</NuxtLink>
				</n-space>
			</div>
			<div class="navigation__logged-in"></div>
		</nav>
		<div v-show="showMenu" class="mobile-menu-container">
			<div class="mobile-menu">
				<div class="mobile-menu__header">
					<div />
					<NuxtLink @click="showMenu = !showMenu" to="/"><img class="logo--size logo" src="~/assets/img/logo.svg" alt="Lumory logo"></NuxtLink>
					<svg class="close-menu icon--size" @click="showMenu = !showMenu" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 0 24 24">
						<path d="M19 6.41L17.59 5L12 10.59L6.41 5L5 6.41L10.59 12L5 17.59L6.41 19L12 13.41L17.59 19L19 17.59L13.41 12z" fill="currentColor"></path>
					</svg>
				</div>
				<nav class="mobile-navigation">
					<NuxtLink @click="showMenu = !showMenu" to="/student" class="navigation__link --white">Studenten</NuxtLink>
					<NuxtLink @click="showMenu = !showMenu" to="/stagebedrijf" class="navigation__link --white">Stagebedrijven</NuxtLink>
					<NuxtLink @click="showMenu = !showMenu" to="/werkgever" class="navigation__link --white">Werkgevers</NuxtLink>
					<NuxtLink @click="showMenu = !showMenu" to="/signin" class="navigation__link --white">Log in</NuxtLink>
					<NuxtLink @click="showMenu = !showMenu" to="/signup" class="navigation__link --white">Registreren</NuxtLink>
				</nav>
			</div>
		</div>
	</Container>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import { NButton, NSpace } from 'naive-ui';

export default defineComponent({
	data() {
		return {
			showMenu: false,
		};
	},
	components: {
		NButton,
		NSpace,
	},
});

</script>

<style scoped>
.container {
	display: flex;
	max-height: 70px;
	height: 70px;
	flex-direction: row;
	justify-content: space-between;
	align-items: center;
}
.logo:hover {
	cursor: pointer;
}
.long-logo--size {
	width: 200px;
}
.logo--size {
	height: 60px;
}
.burger-menu:hover {
	cursor: pointer;
}
.icon--size {
	width: 40px;
}
.mobile-menu-container {
	position: absolute;
	height: 100vh;
	width: 100vw;
	bottom: 0;
	left: 0;
	background-color: rgba(13, 0, 255, 0.171);
	z-index: 1;
}
.mobile-menu {
	position: fixed;
	height: 100%;
	width: 100%;
	right: 0;
	background-color: var(--color-background-two);
}
.mobile-menu__header {
	height: 70px;
	display: flex;
	align-items: center;
	justify-content: space-between;
	margin: 10px;
	margin-left: 10%;
}
.close-menu {
	color: white;
}
.close-menu:hover {
	cursor: pointer;
}
.mobile-navigation {
	display: flex;
	flex-direction: column;
	gap: 45px;
	margin-top: 10%;
	margin-left: 10%;
}
.navigation {
	display: none;
	gap: 20px;
	align-items: center;
}
.navigation__link {
	padding: 10px;
}
.navigation__link:hover {
	cursor: pointer;
	color: rgb(128, 128, 128);
}
.navigation__register-button{
	background-color: var(--color-primary);
	color: var(--color-white);
	border: none;
}
.navigation__logged-out {
	display: flex;
	gap: 20px;
}

@media screen and (min-width: 1024px) {
	.burger-menu {
		display: none;
	}
	.navigation {
		display: flex;
	}
}
</style>
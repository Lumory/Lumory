<template>
	<Container>
		<div class="page-grid"></div>

		<div class="banner">
			<div class="banner-landscape">
				<img src="@/assets/img/Test.jpg" alt="Banner landscape image" class="banner-landscape-image">
			</div>
			<div class="banner-content--positioning">
				<div class="banner-profile-picture">
					<img src="@/assets/img/test2.jpg" alt="Profile picture" class="banner-profile-picture-image">
				</div>
				<div class="banner__content">
					<h3 class="banner__content-name">Niels Berning</h3>
					<h4 class="banner__content-subtitle">Open-ICT, Hogeschool Utrecht</h4>
				</div>
			</div>
		</div>

		<div>opleiding</div>
		<div>externe links</div>
		<div>cv</div>
		<div>stagevoorkeuren</div>
		<div>stagebedrijf voorkeuren</div>
		<div>persoonlijkheidskenmerken</div>
		<div>vaardigheden</div>
	</Container>
</template>

<style scoped>
.page-grid {
	width: 100%;
	background-color: orange;
	display: grid;
}
.banner {
	width: 100%;
	background-color: var(--color-white);
	border-radius: 0 0 3px 3px;
	-webkit-box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05); 
	box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);
}
.banner-landscape {
	/* max-height: 168px; */
	overflow: hidden;
}
.banner-landscape-image {
	width: 100%;
	max-height: 168px;
	object-fit: cover;
	object-position: 50% 50%;
}
.banner-content--positioning {
	display: flex;
	min-height: 100px;
}
.banner-profile-picture {
	min-width: 100px;
	width: 100px;
	height: 100px;
	overflow: hidden;
	border-radius: 50%;
	z-index: 1;
	margin-top: -30px;
	margin-left: 10px;
}
.banner-profile-picture-image {
	object-fit: cover;
	object-position: center;
	max-width: 150px;
	max-height: 150px;
}
.banner__content {
	margin-left: 15px;
}
.banner__content-name {
	padding-bottom: 5px;
}
.banner__content-subtitle {
	font-weight: 500;
}

@media (min-width: 640px) {
	.banner-profile-picture {
		width: 150px;
		height: 150px;
		margin-left: 60px;
		margin-top: -45px;
	}
	.banner-profile-picture-image {
		max-height: none;
	}
	.banner__content {
		margin-left: 25px;
	}
	.banner-content--positioning {
	min-height: 130px;
	}
}

</style>
type Skill = {
    title: String
    description: String
    imageURL: String
}
type StudentQuestionnaire = {
    id: Number
    userId: Number
    problem: string[]
    skillsToLearn: string[]
    strongQualities: string[]
    strongSkills: string[]
    sector: string[]
    teamwork: string[]
    mentorship: string[]
    city: string
    educationalInstitution: string
    study: string
    studyDirection: string
    studyNiveau: string
    averageGrade: Number
    internshipType: string
    dateStart: string
    hours: Number
    days: string
    createdAt: String
    updatedAt: String
}
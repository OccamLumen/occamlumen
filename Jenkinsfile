def COMPOSE_ARGS = '--abort-on-container-exit --no-log-prefix'

pipeline {
    agent any

    options { 
        disableConcurrentBuilds() 
    }

    stages {
        stage('Build') {
            steps {
                sh "docker-compose up ${COMPOSE_ARGS} build"
            }
        }
        stage('Test') {
            steps {
                sh "docker-compose up ${COMPOSE_ARGS} test"
            }
        }
    }

    post {
        always {
            sh "docker-compose up ${COMPOSE_ARGS} fix_ownership"
        }
        cleanup {
            sh "bash ./admin_scripts/cleanup.sh"
        }
    }
}

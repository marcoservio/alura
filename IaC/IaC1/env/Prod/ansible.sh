#!/bin/bash
cd /home/ubuntu
curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py
sudo python3 get-pip.py
sudo python3 -m pip install ansible
tee -a playbook.yml > /dev/null <<EOT
- hosts: localhost
  tasks:
    - name: criando o arquivo
      copy:
        dest: /home/ubuntu/index.html
        content: <h1>Esse bilhete é verdade</h1>
    - name: criando o servidor
      shell: "nohup busybox httpd -f -p 8080 &"
    - name: Instalando o python3 virtualenv
      apt:
        pkg:
          - python3
          - virtualenv
        update_cache: true #apt update e apt upgrade
      become: true #usuario root
    - name: Git Clone
      ansible.builtin.git:
        repo: nome_repositorio_git
        dest: /home/ubuntu/tcc
        version: master
        force: yes
    - name: Instalando dependencias com pip
      pip:
        virtualenv: /home/ubuntu/tcc/venv
        requirements: /home/ubuntu/tcc/requirements.txt
    - name: Alterando o hosts do settings
      lineinfile:
        path: /home/ubuntu/tcc/setup/settings.py
        regexp: "ALLOWED_HOSTS"
        line: "ALLOWED_HOSTS = ['*']"
        backrefs: yes
    - name: Configurando o banco de dados
      shell: ". /home/ubuntu/tcc/venv/bin/activate; python /home/ubuntu/tcc/manage.py migrate"
    - name: Carregando os dados iniciais
      shell: ". /home/ubuntu/tcc/venv/bin/activate; python /home/ubuntu/tcc/manage.py loaddata clientes.json"
    - name: Iniciando o servidor
      shell: ". /home/ubuntu/tcc/venv/bin/activate; nohup python /home/ubuntu/tcc/manage.py runserver 0.0.0.0:8000 &"
EOT
ansible-playbook playbook.yml
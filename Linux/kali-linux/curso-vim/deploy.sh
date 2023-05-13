#!/bin/bash

#pega o tempo que começou
start=`date +%s`
rm -rf apache-tomcat-8.5.88*
wget https://dlcdn.apache.org/tomcat/tomcat-8/v8.5.88/bin/apache-tomcat-8.5.88.tar.gz
tar -xvf apache-tomcat-8.5.88.tar.gz
rm apache-tomcat-8.5.88.tar.gz
mkdir apache-tomcat-8.5.88/webapps/MyApp
cp -r ~/topcasafina/* ~/apache-tomcat-8.5.88/webapps/MyApp
sudo apt install default-jdk
~/apache-tomcat-8.5.88/bin/startup.sh
echo "Deploy feito no dia $(date)" >> log.txt
#pega o tempo que terminou
end=`date +%s`
echo "Deploy foi feito em $((end-start)) segundos"

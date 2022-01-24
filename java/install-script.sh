# curl -L https://download.jetbrains.com/idea/ideaIC-2021.3.1.tar.gz\?_gl\=1\*1c2l4w0\*_ga\*MTI5MjkwNDY3Mi4xNjQyMTU1NDE4\*_ga_V0XZL7QHEB\*MTY0Mjk3ODA1My4xLjEuMTY0Mjk3ODEwMy4w\&_ga\=2.174834278.510798756.1642978053-1292904672.1642155418 -o idea.tar.gz
# tar xvf idea.tar.gz -C ~/Desktop/intellij
#
#export APP=webstorm
#export CODE=WS
#
#export APP=phpstorm
#export CODE=PS
#
#export APP=idea
#export CODE=IIU
#
#export APP=idea
#export CODE=IIC
#
#sudo mkdir /opt/${APP}
#sudo curl -L "https://download.jetbrains.com/product?code=${CODE}&latest&distribution=linux" | sudo tar xvz -C /opt/jb-${CODE} --strip 1

# graphic env
/opt/jb-${CODE}/bin/${APP}.sh

# configure vnc
sudo vi /etc/systemd/system/vncserver@.service
# change to resolution 1900x1150


sudo apt-get update
sudo apt-get install -y php7.4 php-xdebug php-xml  php-mbstring openjdk-13-jdk
for app in phpstorm webstorm intellij-idea-ultimate node; do
  sudo snap install $app --classic
done


php -r "copy('https://getcomposer.org/installer', 'composer-setup.php');"
#php -r "if (hash_file('sha384', 'composer-setup.php') === '906a84df04cea2aa72f40b5f787e49f22d4c2f19492ac310e8cba5b96ac8b64115ac402c8cd292b8a03482574915d1a8') { echo 'Installer verified'; } else { echo 'Installer corrupt'; unlink('composer-setup.php'); } echo PHP_EOL;"
php composer-setup.php
php -r "unlink('composer-setup.php');"


mkdir ~/formation
cd ~/formation
git clone https://github.com/martinsson/kata-setup.git
git clone https://github.com/martinsson/mock-and-stub-introduction.git
git clone https://github.com/martinsson/trip-service-kata.git




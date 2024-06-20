git reset --hard
sleep 120
npm test && git commit -am'wip'  || git reset --hard

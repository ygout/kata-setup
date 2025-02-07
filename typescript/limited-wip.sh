
limit=120
# watch the state of the git changes, whenever the state is not pristine, start a counter that will increment,
# when the counter reaches 120s, reset the changes
# whenever the state becomes pristine again, reset the counter
while true; do
  if [ -z "$(git status --porcelain)" ]; then
    echo "clean"
    sleep 1
  else
    echo "dirty"
    counter=0
    while [ $counter -lt ${limit} ]; do
      if [ -z "$(git status --porcelain)" ]; then
        echo "clean"
        break
      # else echo time elapsed
      else
        echo "dirty for $counter seconds"
      fi
      sleep 1
      counter=$((counter+1))
    done
    if [ $counter -eq ${limit} ]; then
      git add -A .
      git reset --hard
      echo "reset"
    fi
  fi
done


find -type d | grep obj$ | xargs rm -r
find -type d | grep bin$ | xargs rm -r
find -type d | grep Release$ | xargs rm -r
find -type d | grep Debug$ | xargs rm -r

rm -f *.tar.gz




git filter-branch --env-filter \
'if [ $GIT_COMMIT = 19b24ccdf84bd2450a4f75990f46a1e1eabd6dca ]
then
export GIT_AUTHOR_DATE="Sat May 30 01:03:05 2020 VET"
export GIT_COMMITTER_DATE="Sat May 30  01:03:05 2020 -VET"
fi'
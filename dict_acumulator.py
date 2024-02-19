import csv

from collections import Counter

with open("popular_tracks.csv") as f:
    reader = csv.DictReader(f)
    counts = Counter()

    for row in reader:
        artist = row["Artists"]
        counts[artist] += int(row["Popularity"])

#print dict ordered
for artist, count in counts.most_common(10):
    print(f"{artist}: {count}")
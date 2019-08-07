## ML

```bash
dotnet tool install -g mlnet
mlnet auto-train \
    --task binary-classification \
    --dataset "resource/wikipedia-detox-250-line-data.tsv" \
    --label-column-name "Sentiment" \
    --max-exploration-time 10
```
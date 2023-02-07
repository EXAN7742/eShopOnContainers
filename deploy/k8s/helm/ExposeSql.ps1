export POD_NAME=$(kubectl get pods --namespace {{ .Release.Namespace }} -l "app={{ template "sql-data.name" . }},release={{ .Release.Name }}" -o jsonpath="{.items[0].metadata.name}")
echo "Visit http://127.0.0.1:8080 to use your application"
kubectl port-forward $POD_NAME 8080:80
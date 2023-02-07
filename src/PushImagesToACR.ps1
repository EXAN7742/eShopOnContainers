docker tag eshop/webhooks.client:linux-latest eShopMy01ACR.azurecr.io/eshop/webhooks.client:linux-latest
docker tag eshop/basket.api:linux-latest eShopMy01ACR.azurecr.io/eshop/basket.api:linux-latest
docker tag eshop/payment.api:linux-latest eShopMy01ACR.azurecr.io/eshop/payment.api:linux-latest
docker tag eshop/catalog.api:linux-latest eShopMy01ACR.azurecr.io/eshop/catalog.api:linux-latest
docker tag eshop/ordering.backgroundtasks:linux-latest eShopMy01ACR.azurecr.io/eshop/ordering.backgroundtasks:linux-latest
docker tag eshop/webhooks.api:linux-latest eShopMy01ACR.azurecr.io/eshop/webhooks.api:linux-latest
docker tag eshop/identity.api:linux-latest eShopMy01ACR.azurecr.io/eshop/identity.api:linux-latest
docker tag eshop/webstatus:linux-latest eShopMy01ACR.azurecr.io/eshop/webstatus:linux-latest
docker tag eshop/ordering.api:linux-latest eShopMy01ACR.azurecr.io/eshop/ordering.api:linux-latest
docker tag eshop/coupon.api:linux-latest eShopMy01ACR.azurecr.io/eshop/coupon.api:linux-latest
docker tag eshop/webmvc:linux-latest eShopMy01ACR.azurecr.io/eshop/webmvc:linux-latest
docker tag eshop/ordering.signalrhub:linux-latest eShopMy01ACR.azurecr.io/eshop/ordering.signalrhub:linux-latest
docker tag eshop/webspa:linux-latest eShopMy01ACR.azurecr.io/eshop/webspa:linux-latest
docker tag eshop/webshoppingagg:linux-latest eShopMy01ACR.azurecr.io/eshop/webshoppingagg:linux-latest
docker tag eshop/mobileshoppingagg:linux-latest eShopMy01ACR.azurecr.io/eshop/mobileshoppingagg:linux-latest

docker push eShopMy01ACR.azurecr.io/eshop/webhooks.client:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/basket.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/payment.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/catalog.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/ordering.backgroundtasks:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/webhooks.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/identity.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/webstatus:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/ordering.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/coupon.api:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/webmvc:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/ordering.signalrhub:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/webspa:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/webshoppingagg:linux-latest
docker push eShopMy01ACR.azurecr.io/eshop/mobileshoppingagg:linux-latest
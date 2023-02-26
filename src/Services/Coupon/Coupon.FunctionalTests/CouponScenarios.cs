namespace Coupon.FunctionalTests;

public class CouponScenarios
    : CouponScenariosBase
{
    [Fact]
    public async Task Get_get_coupon_by_code_and_response_ok_status_code()
    {
        using var server = CreateServer();
        var client = server.CreateClient();
        var response = await client.GetAsync(Get.CouponByCode("DISC-5"));

        response.EnsureSuccessStatusCode();
    }

    [Fact]
    public async Task Get_get_coupon_by_code_and_response_NotFound_status_code()
    {
        using var server = CreateServer();
        var response = await server.CreateClient()
            .GetAsync(Get.CouponByCode("DISC-555"));

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}

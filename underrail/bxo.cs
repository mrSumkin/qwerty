using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C84 RID: 3204
[eiz("PSRCDE")]
[Serializable]
public sealed class bxo : d4
{
	// Token: 0x06004876 RID: 18550 RVA: 0x001DA274 File Offset: 0x001D8474
	private bxo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PSRCDE:CA");
	}

	// Token: 0x06004877 RID: 18551 RVA: 0x001DA290 File Offset: 0x001D8490
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSRCDE:CA", this.a);
	}

	// Token: 0x06004878 RID: 18552 RVA: 0x001DA2AC File Offset: 0x001D84AC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06004879 RID: 18553 RVA: 0x001DA2B4 File Offset: 0x001D84B4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600487A RID: 18554 RVA: 0x001DA2C0 File Offset: 0x001D84C0
	public override TimeSpan ge()
	{
		if (this.a)
		{
			return TimeSpan.FromMinutes(2.0);
		}
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x0600487B RID: 18555 RVA: 0x001DA2EC File Offset: 0x001D84EC
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x0600487C RID: 18556 RVA: 0x001DA2FC File Offset: 0x001D84FC
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x0600487D RID: 18557 RVA: 0x001DA30C File Offset: 0x001D850C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(1.0);
	}

	// Token: 0x0600487E RID: 18558 RVA: 0x001DA31C File Offset: 0x001D851C
	public bxo() : base(bxo.b)
	{
	}

	// Token: 0x0600487F RID: 18559 RVA: 0x001DA32C File Offset: 0x001D852C
	public bxo(bool A_0) : base(bxo.b)
	{
		this.a = A_0;
	}

	// Token: 0x06004880 RID: 18560 RVA: 0x001DA344 File Offset: 0x001D8544
	protected override bool ez(cyt A_0)
	{
		if (base.ez(A_0))
		{
			List<string> list = new List<string>
			{
				"D5",
				"D6",
				"E5",
				"E6"
			};
			string text = e3m.a();
			return text == null || !list.Contains(text);
		}
		return false;
	}

	// Token: 0x06004881 RID: 18561 RVA: 0x001DA3AC File Offset: 0x001D85AC
	protected override void gg(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackHandled", new bool?(false)).Value)
		{
			bjv.a(A_0, "interfacing_xpbl_navcom_technicianReport");
		}
	}

	// Token: 0x04001CB7 RID: 7351
	private new bool a;

	// Token: 0x04001CB8 RID: 7352
	public static readonly string b = "pirateSpyRevealedCall";
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x0200051D RID: 1309
[eiz("DSE")]
[Serializable]
public sealed class aqt : c47, b2h, ISerializable
{
	// Token: 0x060021B4 RID: 8628 RVA: 0x000B3C88 File Offset: 0x000B1E88
	private aqt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("DSE:SN");
			return;
		}
		if (base.GetType() == typeof(aqt))
		{
			this.a = A_0.GetString("_SecretName");
			return;
		}
		this.a = A_0.GetString("DiscoveredSecretEvent+_SecretName");
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x000B3CF8 File Offset: 0x000B1EF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DSE:SN", this.a);
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x000B3D14 File Offset: 0x000B1F14
	public string c()
	{
		return this.a;
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000B3D1C File Offset: 0x000B1F1C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000B3D28 File Offset: 0x000B1F28
	public bool a()
	{
		return true;
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x000B3D2C File Offset: 0x000B1F2C
	public aqt(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000B3D3C File Offset: 0x000B1F3C
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000B3D78 File Offset: 0x000B1F78
	public ecs se()
	{
		return new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(b94.a(), adi.g), "Вы обнаруживаете " + this.a + ".", null)
			})
		});
	}

	// Token: 0x0400145D RID: 5213
	private string a;
}

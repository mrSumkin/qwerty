using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x0200051B RID: 1307
[eiz("LAE")]
[Serializable]
public sealed class ehr : c47, b2h, ISerializable
{
	// Token: 0x060021A7 RID: 8615 RVA: 0x000B3AF4 File Offset: 0x000B1CF4
	private ehr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LAE:M");
			return;
		}
		if (base.GetType() == typeof(ehr))
		{
			this.a = A_0.GetString("_Message");
			return;
		}
		this.a = A_0.GetString("LocaleAlertEvent+_Message");
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x000B3B64 File Offset: 0x000B1D64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LAE:M", this.a);
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000B3B80 File Offset: 0x000B1D80
	public string c()
	{
		return this.a;
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x000B3B88 File Offset: 0x000B1D88
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x000B3B94 File Offset: 0x000B1D94
	public ehr(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000B3BA4 File Offset: 0x000B1DA4
	public bool a()
	{
		return true;
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x000B3BA8 File Offset: 0x000B1DA8
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x000B3BE4 File Offset: 0x000B1DE4
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(adi.i), this.a, null));
		return ecs;
	}

	// Token: 0x0400145B RID: 5211
	private string a;
}

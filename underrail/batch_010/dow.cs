using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Common.Settings;

// Token: 0x020004B5 RID: 1205
[eiz("SCTS")]
[Serializable]
public sealed class dow : ISerializable
{
	// Token: 0x06001EC2 RID: 7874 RVA: 0x000AA9F0 File Offset: 0x000A8BF0
	private dow(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ScrollingCombatTextOptions)A_0.GetValue("SCTS:P", typeof(ScrollingCombatTextOptions));
			this.b = (ScrollingCombatTextOptions)A_0.GetValue("SCTS:S", typeof(ScrollingCombatTextOptions));
			this.c = (ScrollingCombatTextOptions)A_0.GetValue("SCTS:O", typeof(ScrollingCombatTextOptions));
			this.d = A_0.GetInt32("SCTS:NL");
			this.e = A_0.GetInt32("SCTS:MTBN");
			if (ell.a() >= 443)
			{
				this.f = A_0.GetBoolean("SCTS:ASD");
				return;
			}
			this.f = true;
			return;
		}
		else
		{
			if (base.GetType() == typeof(dow))
			{
				this.a = (ScrollingCombatTextOptions)A_0.GetValue("_Player", typeof(ScrollingCombatTextOptions));
				this.b = (ScrollingCombatTextOptions)A_0.GetValue("_Selected", typeof(ScrollingCombatTextOptions));
				this.c = (ScrollingCombatTextOptions)A_0.GetValue("_Others", typeof(ScrollingCombatTextOptions));
				this.d = A_0.GetInt32("_NotificationsLifespan");
				this.e = A_0.GetInt32("_MinTimeBetweenNotifications");
				return;
			}
			this.a = (ScrollingCombatTextOptions)A_0.GetValue("ScrollingCombatTextSettings+_Player", typeof(ScrollingCombatTextOptions));
			this.b = (ScrollingCombatTextOptions)A_0.GetValue("ScrollingCombatTextSettings+_Selected", typeof(ScrollingCombatTextOptions));
			this.c = (ScrollingCombatTextOptions)A_0.GetValue("ScrollingCombatTextSettings+_Others", typeof(ScrollingCombatTextOptions));
			this.d = A_0.GetInt32("ScrollingCombatTextSettings+_NotificationsLifespan");
			this.e = A_0.GetInt32("ScrollingCombatTextSettings+_MinTimeBetweenNotifications");
			return;
		}
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x000AAC18 File Offset: 0x000A8E18
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SCTS:P", this.a);
		info.AddValue("SCTS:S", this.b);
		info.AddValue("SCTS:O", this.c);
		info.AddValue("SCTS:NL", this.d);
		info.AddValue("SCTS:MTBN", this.e);
		info.AddValue("SCTS:ASD", this.f);
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x000AAC9C File Offset: 0x000A8E9C
	public ScrollingCombatTextOptions d()
	{
		return this.a;
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x000AACA4 File Offset: 0x000A8EA4
	public void b(ScrollingCombatTextOptions A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000AACB0 File Offset: 0x000A8EB0
	public ScrollingCombatTextOptions g()
	{
		return this.b;
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000AACB8 File Offset: 0x000A8EB8
	public void a(ScrollingCombatTextOptions A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000AACC4 File Offset: 0x000A8EC4
	public ScrollingCombatTextOptions e()
	{
		return this.c;
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x000AACCC File Offset: 0x000A8ECC
	public void c(ScrollingCombatTextOptions A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x000AACD8 File Offset: 0x000A8ED8
	public int b()
	{
		return this.d;
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x000AACE0 File Offset: 0x000A8EE0
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x000AACEC File Offset: 0x000A8EEC
	public int a()
	{
		return this.e;
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000AACF4 File Offset: 0x000A8EF4
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x000AAD00 File Offset: 0x000A8F00
	public bool f()
	{
		return this.f;
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x000AAD08 File Offset: 0x000A8F08
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x000AAD14 File Offset: 0x000A8F14
	public dow()
	{
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x000AAD68 File Offset: 0x000A8F68
	public dow c()
	{
		return new dow
		{
			e = this.e,
			d = this.d,
			c = this.c,
			a = this.a,
			b = this.b,
			f = this.f
		};
	}

	// Token: 0x0400138B RID: 5003
	private ScrollingCombatTextOptions a = ScrollingCombatTextOptions.All;

	// Token: 0x0400138C RID: 5004
	private ScrollingCombatTextOptions b = ScrollingCombatTextOptions.All;

	// Token: 0x0400138D RID: 5005
	private ScrollingCombatTextOptions c = ScrollingCombatTextOptions.All;

	// Token: 0x0400138E RID: 5006
	private int d = 2000;

	// Token: 0x0400138F RID: 5007
	private int e = 300;

	// Token: 0x04001390 RID: 5008
	private bool f = true;
}

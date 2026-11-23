using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Effects;

// Token: 0x020005E9 RID: 1513
[eiz("CFC")]
[Serializable]
public sealed class oa : dth, ISerializable, y9
{
	// Token: 0x060027B9 RID: 10169 RVA: 0x000E6AC4 File Offset: 0x000E4CC4
	private oa(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (FocusConditionMode)A_0.GetValue("CFC:F", typeof(FocusConditionMode));
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x000E6AEC File Offset: 0x000E4CEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("CFC:F", this.a);
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x000E6B04 File Offset: 0x000E4D04
	public FocusConditionMode a()
	{
		return this.a;
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x000E6B0C File Offset: 0x000E4D0C
	public void a(FocusConditionMode A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x000E6B18 File Offset: 0x000E4D18
	public oa()
	{
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x000E6B24 File Offset: 0x000E4D24
	public bool jh(object A_0)
	{
		ll ll = A_0 as ll;
		if (ll != null)
		{
			if (ll.a() != null)
			{
				return this.a(ll.a().Offense.af());
			}
		}
		else
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				return this.a(serviceOrThrow.aqu().v().Offense.af());
			}
		}
		return false;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x000E6BA0 File Offset: 0x000E4DA0
	private bool a(bool A_0)
	{
		if (this.a == FocusConditionMode.FocusedOnly)
		{
			return A_0;
		}
		return this.a != FocusConditionMode.UnfocusedOnly || !A_0;
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x000E6BC4 File Offset: 0x000E4DC4
	public string ji()
	{
		return null;
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x000E6BC8 File Offset: 0x000E4DC8
	public string jj()
	{
		if (this.a == FocusConditionMode.FocusedOnly)
		{
			return "когда сосредоточен";
		}
		if (this.a == FocusConditionMode.UnfocusedOnly)
		{
			return "когда не сосредоточен";
		}
		return null;
	}

	// Token: 0x0400163F RID: 5695
	private FocusConditionMode a;
}

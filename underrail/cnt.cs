using System;
using System.Runtime.Serialization;
using Ouroboros.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x020004B7 RID: 1207
[eiz("VS")]
[Serializable]
public sealed class cnt : ISerializable
{
	// Token: 0x06001EE3 RID: 7907 RVA: 0x000AB148 File Offset: 0x000A9348
	private cnt(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (DisplayResolution)A_0.GetValue("VS:R", typeof(DisplayResolution));
		if (ell.a() >= 649)
		{
			this.b = (OuroborosDisplayMode)A_0.GetValue("VS:D", typeof(OuroborosDisplayMode));
		}
		else if (A_0.GetBoolean("VS:F"))
		{
			this.b = OuroborosDisplayMode.Fullscreen;
		}
		else
		{
			this.b = OuroborosDisplayMode.Windowed;
		}
		if (ell.a() >= 340)
		{
			this.c = A_0.GetBoolean("VS:V");
		}
		else
		{
			this.c = true;
		}
		if (ell.a() >= 557)
		{
			this.d = A_0.GetBoolean("VS:Z");
		}
		if (ell.a() >= 660)
		{
			this.e = A_0.GetBoolean("VS:M");
		}
		if (ell.a() >= 696)
		{
			this.f = (TimelapseShader)A_0.GetValue("VS:S", typeof(TimelapseShader));
		}
		else
		{
			this.f = TimelapseShader.Advanced;
		}
		if (ell.a() >= 703)
		{
			this.g = A_0.GetBoolean("VS:C");
			return;
		}
		this.g = true;
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x000AB2C0 File Offset: 0x000A94C0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VS:R", this.a);
		info.AddValue("VS:D", this.b);
		info.AddValue("VS:V", this.c);
		info.AddValue("VS:Z", this.d);
		info.AddValue("VS:M", this.e);
		info.AddValue("VS:S", this.f);
		info.AddValue("VS:C", this.g);
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000AB354 File Offset: 0x000A9554
	public cnt()
	{
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000AB37C File Offset: 0x000A957C
	public cnt a()
	{
		return new cnt
		{
			a = this.a,
			b = this.b,
			c = this.c,
			d = this.d,
			e = this.e,
			f = this.f,
			g = this.g
		};
	}

	// Token: 0x04001397 RID: 5015
	public DisplayResolution a = DisplayResolution.r1024x768;

	// Token: 0x04001398 RID: 5016
	public OuroborosDisplayMode b;

	// Token: 0x04001399 RID: 5017
	public bool c = true;

	// Token: 0x0400139A RID: 5018
	public bool d;

	// Token: 0x0400139B RID: 5019
	public bool e;

	// Token: 0x0400139C RID: 5020
	public TimelapseShader f = TimelapseShader.Advanced;

	// Token: 0x0400139D RID: 5021
	public bool g = true;
}

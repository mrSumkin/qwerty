using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001122 RID: 4386
[eiz("SVEJ")]
[Serializable]
public sealed class no : cze, ISerializable
{
	// Token: 0x06005DA6 RID: 23974 RVA: 0x0027C1D8 File Offset: 0x0027A3D8
	private no(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("SVEJ:EM");
			this.b = A_0.GetInt32("SVEJ:MC");
			this.c = A_0.GetDouble("SVEJ:MD");
			this.d = (Vector3)A_0.GetValue("SVEJ:L", typeof(Vector3));
			this.e = (e6z)A_0.GetValue("SVEJ:AR", typeof(e6z));
			this.f = (HorizontalDirection?)A_0.GetValue("SVEJ:D", typeof(HorizontalDirection?));
			return;
		}
		if (base.GetType() == typeof(no))
		{
			this.a = A_0.GetString("_EffectModel");
			this.b = A_0.GetInt32("_MaxCycles");
			this.c = A_0.GetDouble("_MaxDuration");
			this.d = (Vector3)A_0.GetValue("_Location", typeof(Vector3));
			this.e = (e6z)A_0.GetValue("_AreaRef", typeof(e6z));
			this.f = (HorizontalDirection?)A_0.GetValue("_Direction", typeof(HorizontalDirection?));
			return;
		}
		this.a = A_0.GetString("SpawnVisualEffectJob+_EffectModel");
		this.b = A_0.GetInt32("SpawnVisualEffectJob+_MaxCycles");
		this.c = A_0.GetDouble("SpawnVisualEffectJob+_MaxDuration");
		this.d = (Vector3)A_0.GetValue("SpawnVisualEffectJob+_Location", typeof(Vector3));
		this.e = (e6z)A_0.GetValue("SpawnVisualEffectJob+_AreaRef", typeof(e6z));
		this.f = (HorizontalDirection?)A_0.GetValue("SpawnVisualEffectJob+_Direction", typeof(HorizontalDirection?));
	}

	// Token: 0x06005DA7 RID: 23975 RVA: 0x0027C3E4 File Offset: 0x0027A5E4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SVEJ:EM", this.a);
		info.AddValue("SVEJ:MC", this.b);
		info.AddValue("SVEJ:MD", this.c);
		info.AddValue("SVEJ:L", this.d);
		info.AddValue("SVEJ:AR", this.e);
		info.AddValue("SVEJ:D", this.f);
	}

	// Token: 0x06005DA8 RID: 23976 RVA: 0x0027C46C File Offset: 0x0027A66C
	public string e()
	{
		return this.a;
	}

	// Token: 0x06005DA9 RID: 23977 RVA: 0x0027C474 File Offset: 0x0027A674
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DAA RID: 23978 RVA: 0x0027C480 File Offset: 0x0027A680
	public double b()
	{
		return this.c;
	}

	// Token: 0x06005DAB RID: 23979 RVA: 0x0027C488 File Offset: 0x0027A688
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005DAC RID: 23980 RVA: 0x0027C494 File Offset: 0x0027A694
	public int c()
	{
		return this.b;
	}

	// Token: 0x06005DAD RID: 23981 RVA: 0x0027C49C File Offset: 0x0027A69C
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005DAE RID: 23982 RVA: 0x0027C4A8 File Offset: 0x0027A6A8
	public Vector3 f()
	{
		return this.d;
	}

	// Token: 0x06005DAF RID: 23983 RVA: 0x0027C4B0 File Offset: 0x0027A6B0
	public void a(Vector3 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005DB0 RID: 23984 RVA: 0x0027C4BC File Offset: 0x0027A6BC
	public e6z d()
	{
		return this.e;
	}

	// Token: 0x06005DB1 RID: 23985 RVA: 0x0027C4C4 File Offset: 0x0027A6C4
	public void a(e6z A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005DB2 RID: 23986 RVA: 0x0027C4D0 File Offset: 0x0027A6D0
	public HorizontalDirection? a()
	{
		return this.f;
	}

	// Token: 0x06005DB3 RID: 23987 RVA: 0x0027C4D8 File Offset: 0x0027A6D8
	public void a(HorizontalDirection? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005DB4 RID: 23988 RVA: 0x0027C4E4 File Offset: 0x0027A6E4
	public no()
	{
	}

	// Token: 0x06005DB5 RID: 23989 RVA: 0x0027C508 File Offset: 0x0027A708
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = (this.e != null) ? this.e.ao() : null;
		if (aud == null)
		{
			aud = cze.a(null, A_0, A_1, A_2);
		}
		if (aud != null)
		{
			aud a_ = aud;
			Vector3 a_2 = this.d;
			HorizontalDirection? a_3 = this.f;
			string a_4 = this.a;
			int a_5 = this.b;
			double a_6 = this.c;
			float? a_7 = dz6.b();
			boj.a(a_, a_2, a_3, a_4, a_5, a_6, null, null, a_7, null);
		}
	}

	// Token: 0x04002548 RID: 9544
	private new string a;

	// Token: 0x04002549 RID: 9545
	private int b = 1;

	// Token: 0x0400254A RID: 9546
	private double c = double.MaxValue;

	// Token: 0x0400254B RID: 9547
	private Vector3 d;

	// Token: 0x0400254C RID: 9548
	private e6z e;

	// Token: 0x0400254D RID: 9549
	private HorizontalDirection? f;
}

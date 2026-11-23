using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000297 RID: 663
[eiz("SCA1")]
[Serializable]
public class qy : f7, ISerializable
{
	// Token: 0x0600135B RID: 4955 RVA: 0x00050F4C File Offset: 0x0004F14C
	protected qy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetInt32("SCA1:CAI");
			this.b = A_0.GetBoolean("SCA1:FSOAF");
			this.c = A_0.GetBoolean("SCA1:FSOAIF");
			return;
		}
		if (base.GetType() == typeof(qy))
		{
			this.a = A_0.GetInt32("_CurrentActionIndex");
			this.b = A_0.GetBoolean("_FailSequenceOnActionFail");
			this.c = A_0.GetBoolean("_FailSequenceOnActionInitializationFail");
			return;
		}
		this.a = A_0.GetInt32("SequentialCompositeAction+_CurrentActionIndex");
		this.b = A_0.GetBoolean("SequentialCompositeAction+_FailSequenceOnActionFail");
		this.c = A_0.GetBoolean("SequentialCompositeAction+_FailSequenceOnActionInitializationFail");
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00051030 File Offset: 0x0004F230
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCA1:CAI", this.a);
		info.AddValue("SCA1:FSOAF", this.b);
		info.AddValue("SCA1:FSOAIF", this.c);
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00051078 File Offset: 0x0004F278
	public bool ac()
	{
		return this.b;
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00051080 File Offset: 0x0004F280
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x0005108C File Offset: 0x0004F28C
	public bool z()
	{
		return this.c;
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00051094 File Offset: 0x0004F294
	public void c(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x000510A0 File Offset: 0x0004F2A0
	public auv aa()
	{
		if (this.a < base.ad().Count)
		{
			return base.ad()[this.a];
		}
		return null;
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x000510CC File Offset: 0x0004F2CC
	protected int ab()
	{
		return this.a;
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x000510D4 File Offset: 0x0004F2D4
	public qy()
	{
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x000510EC File Offset: 0x0004F2EC
	public qy(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x00051104 File Offset: 0x0004F304
	public qy(IEnumerable<auv> A_0) : base(A_0)
	{
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x0005111C File Offset: 0x0004F31C
	public qy(string A_0, IEnumerable<auv> A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00051138 File Offset: 0x0004F338
	protected bool a(int A_0)
	{
		if (base.ad().Count <= A_0 || A_0 == this.a)
		{
			return false;
		}
		base.ad().RemoveAt(A_0);
		if (A_0 < this.a)
		{
			this.a--;
		}
		return true;
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0005118C File Offset: 0x0004F38C
	protected override dc4 dt()
	{
		this.a = 0;
		return this.a();
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x000511A0 File Offset: 0x0004F3A0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		dc4 dc = base.ad()[this.a].n(A_0, A_1);
		if (dc == dc4.e && this.ac())
		{
			return dc4.e;
		}
		if (dc != dc4.b)
		{
			this.a++;
			return this.a();
		}
		return dc4.b;
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x000511F8 File Offset: 0x0004F3F8
	protected override void j4()
	{
		if (this.a >= 0 && this.a < base.ad().Count && base.ad()[this.a].State == dc4.b)
		{
			base.ad()[this.a].k();
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0005125C File Offset: 0x0004F45C
	private dc4 a()
	{
		while (this.a < base.ad().Count && (base.ad()[this.a] == null || !base.ad()[this.a].v(base.y())))
		{
			if (base.ad()[this.a].State == dc4.e && this.z())
			{
				return dc4.e;
			}
			this.a++;
		}
		if (this.a >= base.ad().Count)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x04000A94 RID: 2708
	public new int a;

	// Token: 0x04000A95 RID: 2709
	private bool b = true;

	// Token: 0x04000A96 RID: 2710
	private bool c = true;
}

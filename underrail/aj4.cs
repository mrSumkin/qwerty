using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001123 RID: 4387
[eiz("MLEJ")]
[Serializable]
public sealed class aj4 : cze, ISerializable
{
	// Token: 0x06005DB6 RID: 23990 RVA: 0x0027C590 File Offset: 0x0027A790
	private aj4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("MLEJ:A");
			this.b = (Guid?)A_0.GetValue("MLEJ:I", typeof(Guid?));
			this.c = A_0.GetBoolean("MLEJ:L");
			this.d = A_0.GetBoolean("MLEJ:EJ");
			return;
		}
		if (base.GetType() == typeof(aj4))
		{
			this.a = A_0.GetString("_Area");
			this.b = (Guid?)A_0.GetValue("_Id", typeof(Guid?));
			this.c = A_0.GetBoolean("_Locked");
			this.d = A_0.GetBoolean("_ExecuteJobs");
			return;
		}
		this.a = A_0.GetString("ManipulateLockableEntityJob+_Area");
		this.b = (Guid?)A_0.GetValue("ManipulateLockableEntityJob+_Id", typeof(Guid?));
		this.c = A_0.GetBoolean("ManipulateLockableEntityJob+_Locked");
		this.d = A_0.GetBoolean("ManipulateLockableEntityJob+_ExecuteJobs");
	}

	// Token: 0x06005DB7 RID: 23991 RVA: 0x0027C6CC File Offset: 0x0027A8CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MLEJ:A", this.a);
		info.AddValue("MLEJ:I", this.b);
		info.AddValue("MLEJ:L", this.c);
		info.AddValue("MLEJ:EJ", this.d);
	}

	// Token: 0x06005DB8 RID: 23992 RVA: 0x0027C72C File Offset: 0x0027A92C
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005DB9 RID: 23993 RVA: 0x0027C734 File Offset: 0x0027A934
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005DBA RID: 23994 RVA: 0x0027C740 File Offset: 0x0027A940
	public string c()
	{
		return this.a;
	}

	// Token: 0x06005DBB RID: 23995 RVA: 0x0027C748 File Offset: 0x0027A948
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DBC RID: 23996 RVA: 0x0027C754 File Offset: 0x0027A954
	public bool d()
	{
		return this.c;
	}

	// Token: 0x06005DBD RID: 23997 RVA: 0x0027C75C File Offset: 0x0027A95C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005DBE RID: 23998 RVA: 0x0027C768 File Offset: 0x0027A968
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06005DBF RID: 23999 RVA: 0x0027C770 File Offset: 0x0027A970
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005DC0 RID: 24000 RVA: 0x0027C77C File Offset: 0x0027A97C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b;
		if (this.b == null)
		{
			b0b = A_1;
		}
		else
		{
			aud aud;
			if (!string.IsNullOrEmpty(this.a))
			{
				aud = A_0.Zone.n(this.a);
			}
			else
			{
				aud = A_0.Area;
			}
			if (aud == null)
			{
				return;
			}
			b0b = aud.a(this.b.Value);
			if (b0b == null)
			{
				return;
			}
		}
		d2b aspect = b0b.GetAspect<d2b>();
		if (aspect != null)
		{
			aspect.a(this.d, true);
		}
	}

	// Token: 0x0400254E RID: 9550
	private new string a;

	// Token: 0x0400254F RID: 9551
	private Guid? b;

	// Token: 0x04002550 RID: 9552
	private bool c;

	// Token: 0x04002551 RID: 9553
	private bool d = true;
}

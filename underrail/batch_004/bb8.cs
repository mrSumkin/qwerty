using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001898 RID: 6296
[eiz("PAA")]
[Serializable]
public sealed class bb8 : dyh, ISerializable
{
	// Token: 0x060085A5 RID: 34213 RVA: 0x00376EEC File Offset: 0x003750EC
	private bb8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (CharacterState)A_0.GetValue("PAA:A", typeof(CharacterState));
		this.b = A_0.GetInt32("PAA:P");
		this.c = A_0.GetInt32("PAA:S");
		this.d = (A_0.GetValue("PAA:E", typeof(int?)) as int?);
		this.e = A_0.GetInt32("PAA:C");
	}

	// Token: 0x060085A6 RID: 34214 RVA: 0x00376F8C File Offset: 0x0037518C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PAA:A", this.a);
		info.AddValue("PAA:P", this.b);
		info.AddValue("PAA:S", this.c);
		info.AddValue("PAA:E", this.d);
		info.AddValue("PAA:C", this.e);
	}

	// Token: 0x060085A7 RID: 34215 RVA: 0x00377000 File Offset: 0x00375200
	public CharacterState e()
	{
		return this.a;
	}

	// Token: 0x060085A8 RID: 34216 RVA: 0x00377008 File Offset: 0x00375208
	public void a(CharacterState A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060085A9 RID: 34217 RVA: 0x00377014 File Offset: 0x00375214
	public int b()
	{
		return this.b;
	}

	// Token: 0x060085AA RID: 34218 RVA: 0x0037701C File Offset: 0x0037521C
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060085AB RID: 34219 RVA: 0x00377028 File Offset: 0x00375228
	public int c()
	{
		return this.c;
	}

	// Token: 0x060085AC RID: 34220 RVA: 0x00377030 File Offset: 0x00375230
	public void c(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060085AD RID: 34221 RVA: 0x0037703C File Offset: 0x0037523C
	public int? a()
	{
		return this.d;
	}

	// Token: 0x060085AE RID: 34222 RVA: 0x00377044 File Offset: 0x00375244
	public void a(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060085AF RID: 34223 RVA: 0x00377050 File Offset: 0x00375250
	public int d()
	{
		return this.e;
	}

	// Token: 0x060085B0 RID: 34224 RVA: 0x00377058 File Offset: 0x00375258
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060085B1 RID: 34225 RVA: 0x00377064 File Offset: 0x00375264
	public bb8()
	{
	}

	// Token: 0x060085B2 RID: 34226 RVA: 0x00377080 File Offset: 0x00375280
	protected override auv wy()
	{
		if (base.g() != null)
		{
			c5x c5x = base.g().ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				return new e4t(c5x.h.b, this.a, this.b, this.c, this.d, this.e);
			}
		}
		return null;
	}

	// Token: 0x0400332F RID: 13103
	private CharacterState a;

	// Token: 0x04003330 RID: 13104
	private int b = cux.a;

	// Token: 0x04003331 RID: 13105
	private int c;

	// Token: 0x04003332 RID: 13106
	private new int? d;

	// Token: 0x04003333 RID: 13107
	private new int e = 1;
}

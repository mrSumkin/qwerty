using System;
using System.Runtime.Serialization;

// Token: 0x02001AB8 RID: 6840
[eiz("SCXSE")]
[Serializable]
public sealed class afx : els, ISerializable
{
	// Token: 0x06009452 RID: 37970 RVA: 0x003A5EC4 File Offset: 0x003A40C4
	private afx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06009453 RID: 37971 RVA: 0x003A5ED0 File Offset: 0x003A40D0
	public override bool Refreshable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06009454 RID: 37972 RVA: 0x003A5ED8 File Offset: 0x003A40D8
	public afx(int A_0) : base(afx.a, "Скремблирование КорТех", ci8.c)
	{
		base.Icon = "Status.98";
		this.y = "REJ0";
		this.aa = "REJ0";
		base.StaticEffects.Add(new awd());
		base.VisualEffects.Add(new ud(this, "ScrambledAi"));
		base.Duration = A_0;
	}

	// Token: 0x06009455 RID: 37973 RVA: 0x003A5F44 File Offset: 0x003A4144
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/ScrambledCortex");
	}

	// Token: 0x04003909 RID: 14601
	public new static readonly string a = "scrambledCortex";
}

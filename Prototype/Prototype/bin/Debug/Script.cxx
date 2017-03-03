#encoding "utf-8"
#GRAMMAR_ROOT S

Entity -> 'дорого' | 'дёшего' | 'заоблачная' | 'плата' | 'расценка' | 'стоимость' | 'цена';

AdjCoord -> Adj;
AdjCoord -> AdjCoord<gnc-agr[1]> ',' Adj<gnc-agr[1], l-reg>;
AdjCoord -> AdjCoord<gnc-agr[1]> 'и' Adj<gnc-agr[1], l-reg>;
MegaWord -> Word | Word Prep<l-reg> | Prep Word<l-reg> | Prep Word<l-reg> Prep<l-reg>;
S1 -> Entity;
S2 -> Entity<gnc-agr[1]> (Prep) AdjCoord<gnc-agr[1], l-reg> | AdjCoord<gnc-agr[2]> (Prep) Entity<gnc-agr[2], l-reg> | AdjCoord<gnc-agr[3]> (Prep) Entity<gnc-agr[3]> (Prep) AdjCoord<gnc-agr[3], l-reg>;
S3 -> Verb (Verb<l-reg>) (Prep) Entity<l-reg> | Entity (Prep) Verb<l-reg> (Verb<l-reg>);
S4 -> S1 | S2 | S3;
S5 -> Word<gnc-agr[1]> (Prep) S4<gnc-agr[1], l-reg> | S4<gnc-agr[2]> (Prep) Word<gnc-agr[2], l-reg> | Word<gnc-agr[3]> (Prep) S4<gnc-agr[3], l-reg> (Prep) Word<gnc-agr[3], l-reg>;
S6 -> MegaWord<gnc-agr[1]> (Prep) S4<gnc-agr[1], l-reg> | S4<gnc-agr[2]> (Prep) MegaWord<gnc-agr[2], l-reg> | MegaWord<gnc-agr[3]> (Prep) S4<gnc-agr[3], l-reg> (Prep) MegaWord<gnc-agr[3], l-reg>;
S7 -> S5 | S6;
S -> (Prep) S7;